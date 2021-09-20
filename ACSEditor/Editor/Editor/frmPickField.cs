using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aptify.Framework.Application;
using Aptify.Framework.BusinessLogic.GenericEntity;
using Aptify.Framework.DataServices;
using Aptify.Framework.ExceptionManagement;
using Aptify.Framework.WindowsControls;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using MSHTML;

namespace ACSEditor
{
    public partial class frmPickField : Form
    {
        //public frmPickField()
        //{
        //    InitializeComponent();
        //}
        public Editor thiseditor = new Editor();
        string str = "";
        string fldSQL;
        private bool m_bOK;
        private string m_sFieldName;
        private string m_sFieldNameEdit;
        private long m_lEntityID;
        private IAptifyDataAction m_oDataAction;
        private AptifyApplication m_oApplication;
        private UserCredentials m_oUserCredential;
        private DataAction m_oda = new DataAction();
        private AptifyProperties m_oProps = new AptifyProperties();
        private AptifyApplication m_oApp = new AptifyApplication();
        private ImageList ImageList = new ImageList();
        TextBox TextBox = new TextBox();

        public frmPickField() => this.InitializeComponent();
        public string FieldName() => this.m_sFieldName;
        public bool OK() => this.m_bOK;


        public int EId;
        public string editField;
        public string SQL;
        public void Config()
        {
           
            this.m_lEntityID = EId;
            
            this._tvwMain.ImageList = ImageList;
            this.m_oDataAction = (IAptifyDataAction)InstanceCreator.get_CreateInstanceFromName("AptifyGenericDataServices", "Aptify.Framework.DataServices.DataAction");
           //this.PickFieldLocalization();
            this.LoadTree();
        }

        private void _cmdSelectField_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = this._tvwMain.SelectedNode;
            if (selectedNode == null)
                return;
            if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(selectedNode.Tag.ToString().Substring(0, 4), "FLD_", false) == 0)
            {
                this.m_sFieldName = selectedNode.Text;
                this.m_bOK = true;
                
                insertField();
                this.Hide();
            }
            else
            {
                int num = (int)AptifyMessageBox.CultureMsgBox("AptifyMessagingGUI.frmPickField.cmdSelectField_Click.MustSelectAField", "You must select a field.", m_oda.UserCredentials, MsgBoxStyle.Information, ExceptionManager.get_MessageBoxCaption((Control)this));
            }
        }
        private void insertField()
        {

            m_sFieldNameEdit = "<<" + m_sFieldName + ">>";

            Clipboard.SetText(m_sFieldNameEdit);
            if (Clipboard.ContainsText())
            {
                thiseditor.Paste();
            } 

        }
        private void tvwMain_DblClick(object eventSender, EventArgs eventArgs)
        {
            TreeNode selectedNode = this._tvwMain.SelectedNode;
            if (selectedNode == null || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(selectedNode.Tag.ToString().Substring(0, 4), "FLD_", false) != 0)
                return;
            this.m_sFieldName = selectedNode.Text;
            this.m_bOK = true;
            insertField();
            this.Hide();
        }
        private void LoadTree()
        {
            //NEED TO MAKE SURE WE ARE NOT GIVING THE SAME FIELD AS THE EDITOR IS TIED TO AS IT IS RECURSIVE.
            //string SQL = "SELECT Name,Category FROM vwEntityFields WHERE EntityID =" + Conversions.ToString(this.m_lEntityID) + " and Name <> '" + editField + "' ORDER BY sequence";
            //string entityName = "select name from Entities WHERE ID = " + m_lEntityID;
            fldSQL = SQL;
            //string SQL = "SELECT FieldName FROM " + entityName + " ORDER BY ID";
            //}
            DataTable dataTable = this.m_oda.GetDataTable(SQL);
            try
            {
                int num = 0;
                str = "";
                this._tvwMain.Nodes.Clear();
                try
                {
                    TreeNode treeNode1 = new TreeNode();
                    
                        treeNode1 = this._tvwMain.Nodes.Add("Select Field");
                        
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (this.m_oApp.GetEntityPermissions(this.m_lEntityID).Read == EntityPermissionType.Allow)
                        {
                            
                            TreeNode treeNode2 = treeNode1.Nodes.Add(Convert.ToString(RuntimeHelpers.GetObjectValue(row["Name"])).Trim());
                            treeNode2.Tag = (object)("FLD_" + Convert.ToString(RuntimeHelpers.GetObjectValue(row["Name"])).Trim());
                            
                            checked { ++num; }
                        }
                    }
                }
                finally
                {
                    
                }
                if (this._tvwMain.Nodes.Count <= 0)                    
                this._tvwMain.Nodes[0].Expand();
            }
            finally
            {
                dataTable?.Dispose();
            }
        }

        private void _cmdHide_Click(object sender, EventArgs e)
        {
            this.m_bOK = false;
            this.Hide();
        }

        private void frmPickField_Load(object sender, EventArgs e)
        {
            Config();

        }
    }
}
