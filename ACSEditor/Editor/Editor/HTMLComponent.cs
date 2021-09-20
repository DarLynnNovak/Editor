using Aptify.Framework.Application;
using Aptify.Framework.BusinessLogic.GenericEntity;
using Aptify.Framework.DataServices;
using Aptify.Framework.WindowsControls;
using System;
using System.Windows.Forms;
namespace ACSEditor
{
	class HTMLComponent : FormComponent
    {
        Editor editor = new Editor();
        string fieldHtml;    
        string fieldName;
        string starthtml;  
        string entitySql;
        int m_lEntityID;
        private AptifyApplication m_oApp = new AptifyApplication();
        private DataAction m_oDA = new DataAction(); 
        private AptifyProperties m_oProps = new AptifyProperties();
        private System.Windows.Forms.Form _parentForm;  
        private AptifyGenericEntityBase oGE; 
        public int EId;
        int RecordId;
        int editorWidth;
        int editorHeight;  
        string isSave;
        public string fldsql;
        public virtual AptifyApplication Application
        {
            get
            {
                return m_oApp;
            }
        }

        protected override void OnFormComponentConfig(AptifyFormTemplateContext FormTemplateContext)
        {
            base.OnFormComponentConfig(FormTemplateContext);
            AptifyProperties properties = FormTemplateContext.Properties;
            editor.editorField = properties.GetProperty("FieldName").ToString();
            if (Convert.ToString(properties.GetProperty("EntityName")) != "" || properties.GetProperty("EntityName") != null)
            {
                entitySql = "SELECT ID FROM entity WHERE Name = '" + Convert.ToString(properties.GetProperty("EntityName")) + "'";
                m_lEntityID = Convert.ToInt32(m_oDA.ExecuteScalar(entitySql));
                EId = m_lEntityID;
                editor.eId = EId;
            }
            if (Convert.ToString(properties.GetProperty("FieldsSql")) != "" || properties.GetProperty("FieldsSql") != null)
            {
                editor.fieldSql = Convert.ToString(properties.GetProperty("FieldsSql"));

            }

            InitializeComponent();

            {
                //  base.OnFormComponentConfig(FormTemplateContext);


                if (properties.GetProperty("FieldName") != null)
                {
                    fieldName = FormTemplateContext.Properties.GetProperty("FieldName").ToString();
                    fieldHtml = this.FormTemplateContext.GE.GetValue(FormTemplateContext.Properties.GetProperty("FieldName").ToString()).ToString();

                    editor.Html = fieldHtml;
                    getDefaultHTML();
                }
                if (properties.GetProperty("EntityName") != null)
                {

                    oGE = (AptifyGenericEntityBase)this.m_oProps.GetProperty("EntityName");
                    RecordId = Convert.ToInt32(FormTemplateContext.GE.GetValue("ID"));
                    oGE = m_oApp.GetEntityObject(Convert.ToString(properties.GetProperty("EntityName")), RecordId);


                }

            }
        }

        private void InitializeComponent()
        {
            AptifyProperties properties = FormTemplateContext.Properties;
            editor.Location = new System.Drawing.Point(0, 0);
            if (properties.GetProperty("Width") != null)
            {
                editorWidth = Convert.ToInt32(properties.GetProperty("Width"));
            }
            if (properties.GetProperty("Height") != null)
            {
                editorHeight = Convert.ToInt32(properties.GetProperty("Height"));
            }
            editor.Size = new System.Drawing.Size(editorWidth, editorHeight);
            //editor.Html = null; 
            starthtml = editor.BodyHtml;
            _parentForm = ParentForm;
            _parentForm.FormClosing += new FormClosingEventHandler(_parentForm_Closing);
            Controls.Add(editor);


        }
        private void getDefaultHTML()
        {

            if (starthtml != fieldHtml && starthtml != "")
            {
                editor.Html = starthtml;
                this.FormTemplateContext.GE.SetValue(fieldName, starthtml);

            }
        }

        void _parentForm_Closing(object sender, FormClosingEventArgs e)
        {

            saveSelectedRecord();


        }

        public void saveSelectedRecord()
        {

            if (!editor.IsDisposed)
            {
                if (editor.Html != fieldHtml.ToString() || FormTemplateContext.GE.IsDirty)
                {

                    if (isSave is null)
                    {
                        var answer = MessageBox.Show("Save this record?", "Save", MessageBoxButtons.YesNo);

                        switch (answer)
                        {
                            case DialogResult.Yes:
                                // SaveForm();
                                isSave = "Yes";
                                this.FormTemplateContext.GE.SetValue(fieldName, editor.Html);
                                this.FormTemplateContext.GE.Save(true);
                                break;
                            case DialogResult.No:
                                isSave = "No";
                                break;
                        }
                    }




                }
            }


        }
    }

}
