var chapterLoadUrl = "";
var fieldLoadUrl = "";

function indexInitialize() {
    $(".deletesuggestion").confirm({
        text: "Are you sure you want to delete this record?",
        title: "",
        confirm: function (form) {
            return $("#" + form.attr("data-formname")).submit();
        },
        cancel: function () {
            return false;
        },
        confirmButton: "Yes",
        cancelButton: "No",
        post: true,
        confirmButtonClass: "btn-danger",
        cancelButtonClass: "btn-default",
        dialogClass: "modal-dialog modal-lg thisdialog"
    });    
}
function suggestionEditInitialize() {
    $(".showrequired").show();
    $(".showlink").hide();
    $("#PersonSuggestionModels_NewFieldName").NobleCount("#newfieldnamecount");
    $("#PersonSuggestionModels_Definition").NobleCount("#definitionnamecount");
    $("#PersonSuggestionModels_FieldValues").NobleCount("#fieldvaluescount");
    $("#PersonSuggestionModels_AdditionalInformation").NobleCount("#additionalinfocount");
    $("#PersonSuggestionModels_DataSourceHierarchy").NobleCount("#datasourcecount");
    $("#PersonSuggestionModels_AssociatedEditChecks").NobleCount("#associatedcheckscount");
    $("#UserInfoData_InstitutionName").NobleCount("#institutioncount");
    $("#savesuggestion").prop("disabled", false);

    if ($("#PersonSuggestionModels_FieldId").val() == "-1") {
        $("#PersonSuggestionModels_SelectedFieldId").val("-1");
    } else {
        $("#PersonSuggestionModels_SelectedFieldId").val("0");
    }

    newfieldname();

    $("#savesuggestion").on("click", function () {
        //$("input[type=submit]").attr("disabled", "disabled");
    });

}
function suggestionAppendixEditInitialize() {
    $(".showrequired").show();
    $(".showlink").hide();
    $(".newappendixname").show();
    $("#PersonSuggestionModels_NewFieldName").NobleCount("#newfieldnamecount");
    $("#PersonSuggestionModels_Definition").NobleCount("#definitionnamecount");
    $("#savesuggestion").prop("disabled",false);

    if ($("#PersonSuggestionModels_FieldId").val() == "-1") {
        $("#PersonSuggestionModels_SelectedFieldId").val("-1");
    } else {
        $("#PersonSuggestionModels_SelectedFieldId").val("0");
    }

    newfieldname();

    if ($("#PersonSuggestionModels_IsAppendix").val() === true) {
        $(".newappendixname").hide();
    }

    $("#savesuggestion").on("click", function () {
        //$("input[type=submit]").attr("disabled", "disabled");
    });

}
function suggestionNewInitialize() {
    $(".showrequired").show();
    $(".thisrequired").hide();
    $(".showlink").hide();
    $(".newappendixname").hide();
    $(".newfield_name").hide();
    $("#PersonSuggestionModels_NewFieldName").NobleCount("#newfieldnamecount");
    $("#PersonSuggestionModels_NewFieldName").NobleCount("#newnamecount");
    $("#PersonSuggestionModels_Definition").NobleCount("#definitionnamecount");
    $("#PersonSuggestionModels_FieldValues").NobleCount("#fieldvaluescount");
    $("#PersonSuggestionModels_AdditionalInformation").NobleCount("#additionalinfocount");
    $("#PersonSuggestionModels_DataSourceHierarchy").NobleCount("#datasourcecount");
    $("#PersonSuggestionModels_AssociatedEditChecks").NobleCount("#associatedcheckscount");
    $("#savesuggestion").prop("disabled",false);

    var shownewfield = $("#PersonSuggestionModels_SelectedFieldId").val();
    var shownewappendix = $("#PersonSuggestionModels_IsAppendix").val();
    var chaptername = $("#PersonSuggestionModels_NtdsChapterId option:selected").text().toLowerCase();
    var fieldDropDown = $("#PersonSuggestionModels_FieldId option:selected").val();

    if (shownewappendix == "true") {
        $(".notappendix").hide();
        $(".newappendixname").hide();
        $("#PersonSuggestionModels_IsAppendix").val(true);
        if (shownewfield == "-1") {
            $(".newfield_name").show();
            $(".newappendixname").show();
            $("label[for=PersonSuggestionModels_NewFieldName]").text(" Name: ");
            $("label[for=PersonSuggestionModels_Definition]").text(" Suggestion: ");
        } else {
            $(".newfield_name").hide();
            $(".newappendixname").hide();
            $("label[for=PersonSuggestionModels_NewFieldName]").text(" Field Name: ");
            $("label[for=PersonSuggestionModels_Definition]").text(" Definition: ");
        }
    }
    else {
        $(".notappendix").show();
        $(".newappendixname").hide();
        $(".newfield_name").hide();
        $("#PersonSuggestionModels_IsAppendix").val(false);
        $("label[for=PersonSuggestionModels_NewFieldName]").text(" Field Name: ");
    }


    if (chaptername != "" && shownewfield == "-1") {
        $(".showdefinition").show();
        $(".newfield_name").show();
        $(".datafields").hide();
    }
    else if (chaptername != "" && fieldDropDown != "") {
        $(".showdefinition").show();
        $(".newfield_name").hide();
        $(".datafields").show();
    }
    else {
        
    }

    $("#newsuggestions #PersonSuggestionModels_NtdsChapterId").on("change", function () {
        var chapterId = $(this).val();
        if ($("#PersonSuggestionModels_NtdsVersionId").val() != "") {
            if (chapterId > 0) {
                var chaptername = $("#PersonSuggestionModels_NtdsChapterId option:selected").text().toLowerCase();
                var fieldDropDown = $("#PersonSuggestionModels_FieldId");
                loadFields(chapterId, fieldDropDown);
            }
            // check regular expression to see if chaptername contains the word appendix in it lowercase
            $(".showlink").show();
            $(".datafields").show();
            $(".newfield_name").hide();
            $(".thisrequired").hide();
            if (chaptername.match(/appendix.*/)) {
                $(".notappendix").hide();
                $(".newappendixname").hide();
                $("label[for=PersonSuggestionModels_Definition]").text(" Suggestion: ");
                $("#PersonSuggestionModels_IsAppendix").val(true);
            }
            else {
                $(".notappendix").show();
                $(".newappendixname").hide();
                $("label[for=PersonSuggestionModels_Definition]").text(" Definition: ");
                $("#PersonSuggestionModels_IsAppendix").val(false);
            }

            $("#FieldId").val("");
            var id = $("#InternalStatusNewEntry").val();
            $("#PersonSuggestionModels_InternalStatusTypeId").val(id);
        } else {
            alert("The Book Version must be selected before the Chapter");
            $("#PersonSuggestionModels_NtdsChapterId").val("");
        }
    });

    $("#newsuggestions #PersonSuggestionModels_NtdsVersionId").on("change", function () {
        var versionId = $(this).val();
        if (versionId > 0) {
            var chapterDropDown = $("#PersonSuggestionModels_NtdsChapterId");
            loadChapters(versionId, chapterDropDown);
            $(".showlink").hide();
            $(".datafields").show();
            $(".newfield_name").hide();
            $(".thisrequired").hide();
            $("#FieldId").val("");
            if (!$("#InternalStatusNewEntry")) {
                var id = $("#InternalStatusNewEntry").val();
                $("#PersonSuggestionModels_InternalStatusTypeId").val(id);
            }
        }
    });

    newfieldname();

    $(".shownewfield").click(function () {
        var chaptername = $("#PersonSuggestionModels_NtdsChapterId option:selected").text().toLowerCase();
        $(".showdefinition").show();
        $(".newfield_name").show();
        $(".datafields").hide();
        $(".thisrequired").show();
        $("#PersonSuggestionModels_SelectedFieldId").val("-1");
        if (chaptername.match(/appendix.*/)) {
            $(".notappendix").hide();
            $(".newappendixname").show();
            $("#PersonSuggestionModels_IsAppendix").val(true);
            $("label[for=PersonSuggestionModels_NewFieldName]").text(" Name: ");
        }
        else {
            $(".notappendix").show();
            $(".newappendixname").hide();
            $("label[for=PersonSuggestionModels_NewFieldName]").text(" Field Name: ");
            $("#PersonSuggestionModels_FieldId").append('<option value="-1" selected>New Field Suggestion</option>');
            if (!$("#InternalStatusNewEntryField")) {
                var id = $("#InternalStatusNewEntryField").val();
                $("#PersonSuggestionModels_InternalStatusTypeId").val(id);
            }
        }
    });
    
    $("#newsuggestions #PersonSuggestionModels_FieldId").on("change", function () {
        $("#PersonSuggestionModels_SelectedFieldId").val("0");
        $(".thisrequired").hide();
        $(".newfield_name").hide();
    });


    $("#savesuggestion").click(function () {
        // $("input[type=submit]").attr("disabled", "disabled");
        if ($("#PersonSuggestionModels_IsAppendix").val() === true)
        {
            $("#newsuggestions input name=[PersonSuggestionModels.IsAppendix]").val(true);
        }

    });

}

function newfieldname() {
        var id = $("#PersonSuggestionModels_SelectedFieldId").val();
        var versionid = $("#PersonSuggestionModels_NtdsVersionId").val();
        var chapterid = $("#PersonSuggestionModels_NtdsChapterId").val();
        if (id == -1) {
            $(".datafields").hide();
            $(".newfieldname").show();
            $(".thisrequired").show();
            $("#PersonSuggestionModels_FieldId").append('<option value="-1" selected>New Field Suggestion</option>');
        }
        else {
            var chapterDropDown = $("#PersonSuggestionModels_NtdsChapterId");
            $(".showlink").hide();
            $(".datafields").show();
            $(".newfieldname").hide();
            $(".thisrequired").hide();
            $("#PersonSuggestionModels_SelectedFieldId").val("0");
            if (versionid == "" || chapterid == "") {
                $(".showlink").hide();
                if (versionid > 0) {
                    loadChapters(versionid, chapterDropDown);
                }
            }
            if (versionid != "" && chapterid != "") {
                $(".showlink").show();
                if (versionid > 0) {
                    loadChapters(versionid, chapterDropDown);
                }
                if (chapterid > 0) {
                    var fieldDropDown = $("#PersonSuggestionModels_FieldId");
                    loadFields(chapterid, fieldDropDown);
                }
            }
        }
    }

function userInfoEditInitialize() {
    $(".numbersOnly").keydown(function() {
        this.value = this.value.replace(/[^0-9\.]/g, '');
    });
    $("#UserInfoData_InstitutionName").NobleCount("#institutioncount");
}


function loadChapters(versionId,chapterDropDown) {
    $.ajax({
        cache: false,
        url: chapterLoadUrl,
        dataType: "json",
        data: { versionId: versionId },
        success: function(data) {
            $(chapterDropDown).empty();
            $.each(data, function (index, optiondata) {
                $(chapterDropDown).append("<option value='" + optiondata.Value + "'>" + optiondata.Text + "</option>");
            });
            $(chapterDropDown).val(0);
        }
    });
}

function loadFields(chapterId, fieldDropDown) {
    $.ajax({
        cache: false,
        url: fieldLoadUrl,
        dataType: "json",
        data: { chapterId: chapterId },
        success: function(data) {
            $(fieldDropDown).empty();
            $.each(data, function(index, optiondata) {
                $(fieldDropDown).append("<option value='" + optiondata.Value + "'>" + optiondata.Text + "</option>");
            });
            $(fieldDropDown).val(0);
        }
    });
}
