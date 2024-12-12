using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

namespace oraplm
{
    public partial class addition : System.Web.UI.Page
    {
        sqldata sd = new sqldata();
        DataSet ds,ds1,ds2,ds3,ds4,ds5,ds6,dsorgassg,dsorg,dsprint = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
            ViewState["cmdsave_Click"] = 0;
            ViewState["cmdsave1_Click"] = 0;
            ViewState["cmdsave2_Click"] = 0;
            ViewState["cmdsave3_Click"] = 0;
            ViewState["cmdsave4_Click"] = 0;
            ViewState["cmdsave5_Click"] = 0;
            ViewState["cmdsave6_Click"] = 0;
            ViewState["cmdupd_Click"] = 0;

            dsorg = sd.sqlselect("select organization_code from org_organization_definitions group by organization_code order by organization_code", "orgset");
            cmborg.DataSource = dsorg.Tables["orgset"];
            cmborg.DataTextField = "organization_code";
            cmborg.DataValueField = "organization_code";
            cmborg.Items.Add(string.Empty);
            cmborg.DataBind();
            cmborg.SelectedItem.Text = String.Empty;
        }

        protected void cmdshow_Click(object sender, EventArgs e)
        {
            String sqlstr = String.Empty;
            String sqlstr1 = String.Empty;
            if (txttmr.Text != String.Empty)
            {
                sqlstr += " and tmr_no='" + txttmr.Text + "'";
            }
            if (txtfrm.Text != String.Empty)
            {
                sqlstr += " and trunc(tmr_date)>='" + txtfrm.Text + "'";
            }
            if (txtto.Text != String.Empty)
            {
                sqlstr += " and trunc(tmr_date)<='" + txtto.Text + "'";
            }

            if (txttmr.Text != String.Empty)
            {
                sqlstr1 += " and process_id='" + txttmr.Text + "'";
            }
            if (txtfrm.Text != String.Empty)
            {
                sqlstr1 += " and trunc(creation_date)>='" + txtfrm.Text + "'";
            }
            if (txtto.Text != String.Empty)
            {
                sqlstr1 += " and trunc(creation_date)<='" + txtto.Text + "'";
            }

            ds = sd.sqlselect("select TMR_DATE,REQUEST_DEPT,CREATION_DATE,LAST_UPDATE_DATE,FILE_NAME,TMR_NO,TOOL_NO,DESIGN_START_DATE,DESIGN_COMPLETED_DATE,APPROVAL_FLAG,TARGET_DATE,REMARKS,TENTATIVE_TRIAL_DATE,HANDING_OVER_DATE,FROMDEPT,(select request_reason from jan_tmr_lines where tmr_no=a.tmr_no)request_reason,(select product_no from jan_tmr_lines where tmr_no=a.tmr_no)product_no,(select tool_type from jan_tmr_lines where tmr_no=a.tmr_no)tool_type,(select count(1) from jan_tmr_approval_hist_t where tmr_no=a.tmr_no)data_upd_cnt,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=1)stage1,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=2)stage2,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=3)stage3,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=4)stage4,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=5)stage5,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=6)stage6 from jan_tmr_header a where 1=1 " + sqlstr + " union select null TMR_DATE,null REQUEST_DEPT,CREATION_DATE,LAST_UPDATE_DATE,null FILE_NAME,to_char(process_id) TMR_NO,TOOL_NO,null DESIGN_START_DATE,null DESIGN_COMPLETED_DATE,null APPROVAL_FLAG,null TARGET_DATE,null REMARKS,null TENTATIVE_TRIAL_DATE,null HANDING_OVER_DATE,null FROMDEPT,null REQUEST_REASON,PRODUCT_NO,null TOOL_TYPE,(select count(1) from jan_tmr_approval_hist_t where tmr_no=a.process_id)data_upd_cnt,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.process_id and stage=1)stage1,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.process_id and stage=2)stage2,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.process_id and stage=3)stage3,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.process_id and stage=4)stage4,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.process_id and stage=5)stage5,(select count(1) from jan_tmr_approval_remarks where tmr_no=a.process_id and stage=6)stage6 from jan_new_tool_hist_t a where 1=1 " + sqlstr1 + "", "set1");
            grid1.DataSource = ds.Tables["set1"];
            grid1.DataBind();

            Int16 iind1;
            foreach (DataGridItem item in grid1.Items)
            {
                iind1 = (Int16)item.ItemIndex;
                if (item.Cells[14].Text != "0")
                {
                    grid1.Items[item.ItemIndex].Cells[6].BackColor = Color.Green;
                    grid1.Items[item.ItemIndex].Cells[6].BackColor = Color.White;


                }
                if (item.Cells[14].Text == "0")
                {
                    grid1.Items[item.ItemIndex].Cells[6].BackColor = Color.Maroon;
                    grid1.Items[item.ItemIndex].Cells[6].BackColor = Color.White;
                }

                if (item.Cells[15].Text != "0")
                {
                    grid1.Items[item.ItemIndex].Cells[7].BackColor = Color.Green;
                    grid1.Items[item.ItemIndex].Cells[7].BackColor = Color.White;


                }
                if (item.Cells[15].Text == "0")
                {
                    grid1.Items[item.ItemIndex].Cells[7].BackColor = Color.Maroon;
                    grid1.Items[item.ItemIndex].Cells[7].BackColor = Color.White;
                }

                if (item.Cells[16].Text != "0")
                {
                    grid1.Items[item.ItemIndex].Cells[8].BackColor = Color.Green;
                    grid1.Items[item.ItemIndex].Cells[8].BackColor = Color.White;


                }
                if (item.Cells[16].Text == "0")
                {
                    grid1.Items[item.ItemIndex].Cells[8].BackColor = Color.Maroon;
                    grid1.Items[item.ItemIndex].Cells[8].BackColor = Color.White;
                }

                if (item.Cells[17].Text != "0")
                {
                    grid1.Items[item.ItemIndex].Cells[9].BackColor = Color.Green;
                    grid1.Items[item.ItemIndex].Cells[9].BackColor = Color.White;


                }
                if (item.Cells[17].Text == "0")
                {
                    grid1.Items[item.ItemIndex].Cells[9].BackColor = Color.Maroon;
                    grid1.Items[item.ItemIndex].Cells[9].BackColor = Color.White;
                }

                if (item.Cells[18].Text != "0")
                {
                    grid1.Items[item.ItemIndex].Cells[10].BackColor = Color.Green;
                    grid1.Items[item.ItemIndex].Cells[10].BackColor = Color.White;


                }
                if (item.Cells[18].Text == "0")
                {
                    grid1.Items[item.ItemIndex].Cells[10].BackColor = Color.Maroon;
                    grid1.Items[item.ItemIndex].Cells[10].BackColor = Color.White;
                }

                if (item.Cells[19].Text != "0")
                {
                    grid1.Items[item.ItemIndex].Cells[11].BackColor = Color.Green;
                    grid1.Items[item.ItemIndex].Cells[11].BackColor = Color.White;


                }
                if (item.Cells[19].Text == "0")
                {
                    grid1.Items[item.ItemIndex].Cells[11].BackColor = Color.Maroon;
                    grid1.Items[item.ItemIndex].Cells[11].BackColor = Color.White;
                }

                if (item.Cells[20].Text != "0")
                {
                    grid1.Items[item.ItemIndex].Cells[12].BackColor = Color.Green;
                    grid1.Items[item.ItemIndex].Cells[12].BackColor = Color.White;


                }
                if (item.Cells[20].Text == "0")
                {
                    grid1.Items[item.ItemIndex].Cells[12].BackColor = Color.Maroon;
                    grid1.Items[item.ItemIndex].Cells[12].BackColor = Color.White;
                }

            }
        }

        protected void grid1_ItemCommand(object source, DataGridCommandEventArgs e)
        {
            ds1 = sd.sqlselect("select a.*,(select detailed_description from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=1)stage1,(select detailed_description from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=2)stage2,(select detailed_description from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=3)stage3,(select detailed_description from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=4)stage4,(select detailed_description from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=5)stage5,(select detailed_description from jan_tmr_approval_remarks where tmr_no=a.tmr_no and stage=6)stage6 from jan_tmr_approval_hist_t a where tmr_no='" + e.Item.Cells[0].Text + "'", "set2");
            if (e.CommandName=="deapprove" & e.Item.Cells[2].Text!= "To eliminate additional operations." & (String)Session["SRG"]== "AD1")
            {
                Session.Add("stmr", e.Item.Cells[0].Text);
                Session.Add("supdcnt", Convert.ToDouble(e.Item.Cells[13].Text));
                foreach (DataRow Titledata in ds1.Tables["set2"].Rows)
                {
                    txttoolcost.Text = Convert.ToString(Titledata["PRESCRIBED_TOOL_COST"]);
                    txtquote.Text = Convert.ToString(Titledata["SUPPLIER_QUOTE"]);
                    txtpdcost.Text = Convert.ToString(Titledata["PRODUCT_DEVELOPMENT_COST"]);
                    txtbudcost.Text = Convert.ToString(Titledata["TOOL_COST_INCLUSION_BUDGET"]);
                    txtdremrk.Text = Convert.ToString(Titledata["DESIGN_REMARKS"]);
                    txtdappby.Text = Convert.ToString(Titledata["DESIGN_APPROVED_BY"]);
                    txtdhead.Text = Convert.ToString(Titledata["DESIGN_HEAD"]);

                    
                }
                if(e.Item.Cells[14].Text==dr1.Text)
                {
                    dr1.Checked = true;
                }
                if (e.Item.Cells[14].Text == dr2.Text)
                {
                    dr2.Checked = true;
                }
                if (e.Item.Cells[14].Text == dr3.Text)
                {
                    dr3.Checked = true;
                }
                if (e.Item.Cells[14].Text == dr4.Text)
                {
                    dr4.Checked = true;
                }
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup();", true);
            }
            if (e.CommandName == "tlapprove" & (String)Session["SRG"] == "AD2")
            {
                foreach (DataRow Titledata in ds1.Tables["set2"].Rows)
                {
                    txttoolreqno.Text= Convert.ToString(Titledata["TOOL_REQUEST_NO"]);
                    txtpartno.Text = Convert.ToString(Titledata["ITEM_NO"]);
                    txtdesc.Text = Convert.ToString(Titledata["DESCRIPTION"]);
                    txttoolest.Text = Convert.ToString(Titledata["TOOLROOM_ESTIMATED_TOOL_COST"]);
                    txtesttoollife.Text = Convert.ToString(Titledata["TOOLROOM_ESTIMATED_TOOL_LIFE"]);
                    txtptoollife.Text = Convert.ToString(Titledata["PRESENT_TOOL_LIFE"]);
                    txtpnocav.Text = Convert.ToString(Titledata["PRESENT_NO_OF_CAVITY"]);
                    txttremrk.Text = Convert.ToString(Titledata["TOOL_ROOM_REMARKS"]);
                    txtappby.Text = Convert.ToString(Titledata["TOOLROOM_APPROVED_BY"]);
                    txtthead.Text = Convert.ToString(Titledata["TOOLROOM_HEAD"]);
                }
                Session.Add("stmr", e.Item.Cells[0].Text);
                Session.Add("supdcnt", Convert.ToDouble(e.Item.Cells[13].Text));

                if (e.Item.Cells[15].Text == tr1.Text)
                {
                    tr1.Checked = true;
                }
                if (e.Item.Cells[15].Text == tr2.Text)
                {
                    tr2.Checked = true;
                }
                if (e.Item.Cells[15].Text == tr3.Text)
                {
                    tr3.Checked = true;
                }
                if (e.Item.Cells[15].Text == tr4.Text)
                {
                    tr4.Checked = true;
                }
                if (e.Item.Cells[15].Text == tr5.Text)
                {
                    tr5.Checked = true;
                }
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup1();", true);
            }
            if (e.CommandName == "mtapprove" & (e.Item.Cells[2].Text!= "Tool required for new product launch" | e.Item.Cells[2].Text!="Tool required for new product launch") & (String)Session["SRG"] == "AD3")
            {
                foreach (DataRow Titledata in ds1.Tables["set2"].Rows)
                {
                    txtstock.Text = Convert.ToString(Titledata["PRESENT_STOCK"]);
                    txtoptimum.Text = Convert.ToString(Titledata["OPTIMUM_QTY"]);
                    txtddsshort.Text = Convert.ToString(Titledata["DDS_SHORTAGE"]);
                    txtpopend.Text = Convert.ToString(Titledata["PO_PENDING"]);
                    txtnos.Text = Convert.ToString(Titledata["NO_OF_SUPPLIERS"]);
                    txttentinc.Text = Convert.ToString(Titledata["TENTATIVE_INCREASE"]);
                    txtpremrk.Text = Convert.ToString(Titledata["MATERIALS_REMARKS"]);
                    txtpappby.Text = Convert.ToString(Titledata["MATERIALS_APPROVED_BY"]);
                    txtmhead.Text = Convert.ToString(Titledata["MATERIALS_HEAD"]);
                }
                Session.Add("stmr", e.Item.Cells[0].Text);
                Session.Add("supdcnt", Convert.ToDouble(e.Item.Cells[13].Text));

                if (e.Item.Cells[16].Text == pr1.Text)
                {
                    pr1.Checked = true;
                }
                if (e.Item.Cells[16].Text == pr2.Text)
                {
                    pr2.Checked = true;
                }
                if (e.Item.Cells[16].Text == pr3.Text)
                {
                    pr3.Checked = true;
                }
                if (e.Item.Cells[16].Text == pr4.Text)
                {
                    pr4.Checked = true;
                }
                if (e.Item.Cells[16].Text == pr5.Text)
                {
                    pr5.Checked = true;
                }
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup2();", true);
            }

            if (e.CommandName == "qapprove" &(e.Item.Cells[2].Text!= "Tool required for new product launch" | e.Item.Cells[2].Text!= "Tool required for prototype development.") & (String)Session["SRG"] == "AD4")
            {
                foreach (DataRow Titledata in ds1.Tables["set2"].Rows)
                {
                    txtrejppm.Text = Convert.ToString(Titledata["CURRENT_REJECTION_PPM"]);
                    txtnocuscomp.Text = Convert.ToString(Titledata["NO_OF_CUSTOMER_COMPLAINTS_COMPONENT"]);
                    txtqremrk.Text = Convert.ToString(Titledata["QUALITY_REMARKS"]);
                    txtqappby.Text = Convert.ToString(Titledata["QUALITY_APPROVED_BY"]);
                    txtqhead.Text = Convert.ToString(Titledata["QUALITY_HEAD"]);
                }
                Session.Add("stmr", e.Item.Cells[0].Text);
                Session.Add("supdcnt", Convert.ToDouble(e.Item.Cells[13].Text));
                if (e.Item.Cells[17].Text == qr1.Text)
                {
                    qr1.Checked = true;
                }
                if (e.Item.Cells[17].Text == qr2.Text)
                {
                    qr2.Checked = true;
                }
                if (e.Item.Cells[17].Text == qr3.Text)
                {
                    qr3.Checked = true;
                }
                if (e.Item.Cells[17].Text == qr4.Text)
                {
                    qr4.Checked = true;
                }
               
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup3();", true);
            }

            if (e.CommandName == "capprove" & e.Item.Cells[2].Text!= "To eliminate additional operations." & (String)Session["SRG"] == "AD5")
            {
                foreach (DataRow Titledata in ds1.Tables["set2"].Rows)
                {
                    txtpbcst.Text = Convert.ToString(Titledata["PRESENT_PROCESS_COST"]);
                    txtestcostpro.Text = Convert.ToString(Titledata["ESTIMATED_COMPONENT_COST_PROPOSAL"]);
                    txtctoolcst.Text = Convert.ToString(Titledata["ESTIMATED_TOOL_COST"]);
                    txtnewtoolcst.Text = Convert.ToString(Titledata["TOTAL_NEW_TOOL_CHANGE_COST"]);
                    txtcremrk.Text = Convert.ToString(Titledata["COSTING_REMARKS"]);
                    txtcappby.Text = Convert.ToString(Titledata["COSTING_APPROVED_BY"]);
                    txtchead.Text = Convert.ToString(Titledata["COSTING_HEAD"]);

                }
                Session.Add("stmr", e.Item.Cells[0].Text);
                Session.Add("supdcnt", Convert.ToDouble(e.Item.Cells[13].Text));
                if (e.Item.Cells[18].Text == cr1.Text)
                {
                    cr1.Checked = true;
                }
                if (e.Item.Cells[18].Text == cr2.Text)
                {
                    cr2.Checked = true;
                }
                if (e.Item.Cells[18].Text == cr3.Text)
                {
                    cr3.Checked = true;
                }
                if (e.Item.Cells[18].Text == cr4.Text)
                {
                    cr4.Checked = true;
                }
                if (e.Item.Cells[18].Text == cr5.Text)
                {
                    cr5.Checked = true;
                }
                if (e.Item.Cells[18].Text == cr6.Text)
                {
                    cr6.Checked = true;
                }
                if (e.Item.Cells[18].Text == cr7.Text)
                {
                    cr7.Checked = true;
                }

                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup4();", true);
            }

            if (e.CommandName == "dbmsapprove" & (String)Session["SRG"] == "AD6")
            {
                foreach (DataRow Titledata in ds1.Tables["set2"].Rows)
                {
                    txttalloc.Text=Convert.ToString(Titledata["TOOL_NO_ALLOCATED"]);
                    txtetoolstat.Text = Convert.ToString(Titledata["STATUS_OF_EXISTING_TOOL"]); 
                    txtdbmsupdby.Text = Convert.ToString(Titledata["DBMS_UPDATED_BY"]); 
                    txtteamoradbms.Text = Convert.ToString(Titledata["ORACLE_DBMS_TEAM"]); 
                }
                Session.Add("stmr", e.Item.Cells[0].Text);
                Session.Add("supdcnt", Convert.ToDouble(e.Item.Cells[13].Text));
                if (e.Item.Cells[19].Text == dbr1.Text)
                {
                    dbr1.Checked = true;
                }

                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup5();", true);
            }
            if (e.CommandName == "finapprove" & (e.Item.Cells[2].Text!= "Tool required for new product launch" | e.Item.Cells[2].Text!= "To eliminate additional operations." | e.Item.Cells[2].Text!= "Tool required for prototype development.") & (String)Session["SRG"] == "AD7")
            {
                foreach (DataRow Titledata in ds1.Tables["set2"].Rows)
                {
                    txtfprojcode.Text = Convert.ToString(Titledata["PROJECT_CODE"]);
                    txtfcstctr.Text = Convert.ToString(Titledata["COST_CENTER"]);
                    txtfallocbud.Text = Convert.ToString(Titledata["ALLOCATED_BUDGET"]);
                    txtappby.Text = Convert.ToString(Titledata["FINANCE_APPROVED_BY"]);
                    txtfhead.Text = Convert.ToString(Titledata["FINANCE_HEAD"]);
                }
                Session.Add("stmr", e.Item.Cells[0].Text);
                Session.Add("supdcnt", Convert.ToDouble(e.Item.Cells[13].Text));
                ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup6();", true);
            }
            if(e.CommandName=="Print")
            {
                Session.Add("stmr", e.Item.Cells[0].Text);
                dsprint = sd.sqlselect("select * from jan_tmr_approval_hist_t where tmr_no='" + e.Item.Cells[0].Text + "'", "printset");
                Session.Add("spds", dsprint);
                System.Web.HttpContext.Current.Response.Write("<script>");
                System.Web.HttpContext.Current.Response.Write("window.open('print.aspx','Qpty','width=970,height=680,toolbar=no,location=no,directories=no,status=no,menubar=no,scrollbars=yes,copyhistory=no, resizable= yes,minimize=no;maximize=no,top=10,left=20');");
                System.Web.HttpContext.Current.Response.Write("</script>");
            }
        }

        protected void cmdbuy_Click(object sender, EventArgs e)
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Popup", "ShowPopup7();", true);
        }

        protected void cmdupd_Click(object sender, EventArgs e)
        {
            Double subval5;
            String Remrk = String.Empty;

            subval5 = (int)ViewState["cmdupd_Click"];

            if (subval5 == 0)
            {
                ViewState["cmdupd_Click"] = 1;
            }
            else
            {
                return;
            }

            sd.sqlsave("insert into jan_new_tool_hist_t(process_id,organization_id,tool_no,description,product_no,product_description,type_of_tool,no_of_cavity,vendor_name,vendor_id)values((select max(process_id)+1 from jan_new_tool_hist_t),jan_orgid('" + cmborg.Text + "'),'" + txtpart.Text + "','" + txtpartdesc.Text + "','"  + txtprod.Text + "','" + txtproddesc.Text + "','" + cmbttype.Text + "','" + txtnocav.Text + "','" + txtsupp.Text + "',(select vendor_id from po_vendors where vendor_name='" + txtsupp.Text + "'))");
            ViewState["cmdupd_Click"] = 0;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data updated...');", true);
        }

            protected void cmdsave_Click(object sender, EventArgs e)
        {
            Double subval5;
            String Remrk = String.Empty;

            subval5 = (int)ViewState["cmdsave_Click"];

            if (subval5 == 0)
            {
                ViewState["cmdsave_Click"] = 1;
            }
            else
            {
                return;
            }
            if ((Double)Session["supdcnt"] == 0)
            {
                sd.sqlsave("insert into jan_tmr_approval_hist_t(tmr_no,prescribed_tool_cost,supplier_quote,product_development_cost,tool_cost_inclusion_budget,design_remarks,design_approved_by,design_head)values('" + (String)Session["stmr"] + "','" + txttoolcost.Text + "','" + txtquote.Text + "','" + txtpdcost.Text + "','" + txtbudcost.Text + "','" + txtdremrk.Text + "','" + txtdappby.Text + "','" + txtdhead.Text + "')");
            }
            if ((Double)Session["supdcnt"] != 0)
            {
                sd.sqlsave("update jan_tmr_approval_hist_t set prescribed_tool_cost='" + txttoolcost.Text + "',supplier_quote='" + txtquote.Text + "',product_development_cost='" + txtpdcost.Text + "',tool_cost_inclusion_budget='" + txtbudcost.Text + "',design_remarks='" + txtdremrk.Text + "',design_approved_by='" + txtdappby.Text + "',design_head='" + txtdhead.Text + "' where tmr_no='" + (String)Session["stmr"] + "'");
            }
            if(dr1.Checked==true)
            {
                Remrk = dr1.Text;
            }
            if (dr2.Checked == true)
            {
                Remrk = dr2.Text;
            }
            if (dr3.Checked == true)
            {
                Remrk = dr3.Text;
            }
            if (dr4.Checked == true)
            {
                Remrk = dr4.Text;
            }
            sd.sqlsave("delete from jan_tmr_approval_remarks where tmr_no='" + (String)Session["stmr"] + "'");
            sd.sqlsave("insert into jan_tmr_approval_remarks('" + (String)Session["stmr"] + "','" + Remrk  + "',1");
            ViewState["cmdsave_Click"] = 0;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data updated...');", true);

        }

        protected void cmdsave1_Click(object sender, EventArgs e)
        {
            Double subval5;
            String Remrk = String.Empty;

            subval5 = (int)ViewState["cmdsave1_Click"];

            if (subval5 == 0)
            {
                ViewState["cmdsave1_Click"] = 1;
            }
            else
            {
                return;
            }

            sd.sqlsave("update jan_tmr_approval_hist_t set tool_request_no='" + txttoolreqno.Text + "',item_no='" + txtpartno.Text + "',description='" + txtdesc.Text + "',toolroom_estimated_tool_cost='" + txttoolest.Text + "',toolroom_estimated_tool_life='" + txtesttoollife.Text + "',present_tool_life='" + txtptoollife.Text + "',present_no_of_cavity='" + txtpnocav.Text + "',tool_room_remarks='"  + txttremrk.Text + "',toolroom_approved_by='" +  txtappby.Text + "',toolroom_head='" + txtthead.Text + "' where tmr_no='" + (String)Session["stmr"] + "'");
            if (tr1.Checked == true)
            {
                Remrk = tr1.Text;
            }
            if (tr2.Checked == true)
            {
                Remrk = tr2.Text;
            }
            if (tr3.Checked == true)
            {
                Remrk = tr3.Text;
            }
            if (tr4.Checked == true)
            {
                Remrk = tr4.Text;
            }
            if (tr5.Checked == true)
            {
                Remrk = tr5.Text;
            }
            sd.sqlsave("delete from jan_tmr_approval_remarks where tmr_no='" + (String)Session["stmr"] + "'");
            sd.sqlsave("insert into jan_tmr_approval_remarks('" + (String)Session["stmr"] + "','" + Remrk + "',2");
            ViewState["cmdsave1_Click"] = 0;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data updated...');", true);

        }

        protected void cmdsave2_Click(object sender, EventArgs e)
        {
            Double subval5;
            String Remrk = String.Empty;

            subval5 = (int)ViewState["cmdsave2_Click"];

            if (subval5 == 0)
            {
                ViewState["cmdsave2_Click"] = 1;
            }
            else
            {
                return;
            }

            sd.sqlsave("update jan_tmr_approval_hist_t set present_stock number='" + txtstock.Text + "',optimum_qty='" + txtoptimum.Text + "',dds_shortage='" + txtddsshort.Text + "',po_pending='" + txtpopend.Text + "',no_of_suppliers='" + txtnos.Text + "',tentative_increase='" + txttentinc.Text + "',materials_remarks='" + txtpremrk.Text + "',materials_approved_by='" + txtpappby.Text +"',materials_head='" + txtmhead.Text + "' where tmr_no='" + (String)Session["stmr"] + "'");
            if (pr1.Checked == true)
            {
                Remrk = pr1.Text;
            }
            if (pr2.Checked == true)
            {
                Remrk = pr2.Text;
            }
            if (pr3.Checked == true)
            {
                Remrk = pr3.Text;
            }
            if (pr4.Checked == true)
            {
                Remrk = pr4.Text;
            }
            if (pr5.Checked == true)
            {
                Remrk = pr5.Text;
            }
            sd.sqlsave("delete from jan_tmr_approval_remarks where tmr_no='" + (String)Session["stmr"] + "'");
            sd.sqlsave("insert into jan_tmr_approval_remarks('" + (String)Session["stmr"] + "','" + Remrk + "',3");
            ViewState["cmdsave2_Click"] = 0;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data updated...');", true);

        }

        protected void cmdsave3_Click(object sender, EventArgs e)
        {

            Double subval5;
            String Remrk = String.Empty;

            subval5 = (int)ViewState["cmdsave3_Click"];

            if (subval5 == 0)
            {
                ViewState["cmdsave3_Click"] = 1;
            }
            else
            {
                return;
            }


            sd.sqlsave("update jan_tmr_approval_hist_t set current_rejection_ppm='" + txtrejppm.Text + "',no_of_customer_complaints_component='" + txtnocuscomp.Text + "',quality_remarks='" + txtqremrk.Text + "',quality_approved_by='" + txtqappby.Text + "',quality_head='" + txtqhead.Text + "'  where tmr_no='" + (String)Session["stmr"] + "'");
            if (qr1.Checked == true)
            {
                Remrk = qr1.Text;
            }
            if (qr2.Checked == true)
            {
                Remrk = qr2.Text;
            }
            if (qr3.Checked == true)
            {
                Remrk = qr3.Text;
            }
            if (qr4.Checked == true)
            {
                Remrk = qr4.Text;
            }
            
            sd.sqlsave("delete from jan_tmr_approval_remarks where tmr_no='" + (String)Session["stmr"] + "'");
            sd.sqlsave("insert into jan_tmr_approval_remarks('" + (String)Session["stmr"] + "','" + Remrk + "',4");
            ViewState["cmdsave3_Click"] = 0;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data updated...');", true);

        }

        protected void cmdsave4_Click(object sender, EventArgs e)
        {
            Double subval5;
            String Remrk = String.Empty;

            subval5 = (int)ViewState["cmdsave4_Click"];

            if (subval5 == 0)
            {
                ViewState["cmdsave4_Click"] = 1;
            }
            else
            {
                return;
            }

            sd.sqlsave("update jan_tmr_approval_hist_t set present_process_cost='" + txtpbcst.Text +"',estimated_component_cost_proposal='" + txtestcostpro.Text + "',estimated_tool_cost='" + txtctoolcst.Text + "',total_new_tool_change_cost='" + txtnewtoolcst.Text + "',costing_remarks='" + txtcremrk.Text + "',costing_approved_by='" + txtcappby.Text +"',costing_head='" + txtchead.Text + "'  where tmr_no='" + (String)Session["stmr"] + "'");
            if (cr1.Checked == true)
            {
                Remrk = cr1.Text;
            }
            if (cr2.Checked == true)
            {
                Remrk = cr2.Text;
            }
            if (cr3.Checked == true)
            {
                Remrk = cr3.Text;
            }
            if (cr4.Checked == true)
            {
                Remrk = cr4.Text;
            }

            if (cr5.Checked == true)
            {
                Remrk = cr5.Text;
            }

            if (cr6.Checked == true)
            {
                Remrk = cr6.Text;
            }
            if (cr7.Checked == true)
            {
                Remrk = cr7.Text;
            }


            sd.sqlsave("delete from jan_tmr_approval_remarks where tmr_no='" + (String)Session["stmr"] + "'");
            sd.sqlsave("insert into jan_tmr_approval_remarks('" + (String)Session["stmr"] + "','" + Remrk + "',5");
            ViewState["cmdsave4_Click"] = 0;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data updated...');", true);

        }

        protected void cmdsave5_Click(object sender, EventArgs e)
        {
            Double subval5;
            String Remrk = String.Empty;

            subval5 = (int)ViewState["cmdsave5_Click"];

            if (subval5 == 0)
            {
                ViewState["cmdsave5_Click"] = 1;
            }
            else
            {
                return;
            }

            sd.sqlsave("update jan_tmr_approval_hist_t set tool_no_allocated='" + txttalloc.Text + "',status_of_existing_tool='" + txtetoolstat.Text + "',dbms_updated_by='" + txtdbmsupdby.Text + "',oracle_dbms_team='" + txtteamoradbms.Text + "'  where tmr_no='" + (String)Session["stmr"] + "'");
            if (dbr1.Checked == true)
            {
                Remrk = dbr1.Text;
            }


            sd.sqlsave("delete from jan_tmr_approval_remarks where tmr_no='" + (String)Session["stmr"] + "'");
            sd.sqlsave("insert into jan_tmr_approval_remarks('" + (String)Session["stmr"] + "','" + Remrk + "',6");
            ViewState["cmdsave5_Click"] = 0;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data updated...');", true);

        }

        protected void cmdsave6_Click(object sender, EventArgs e)
        {
            Double subval5;
            String Remrk = String.Empty;

            subval5 = (int)ViewState["cmdsave6_Click"];

            if (subval5 == 0)
            {
                ViewState["cmdsave6_Click"] = 1;
            }
            else
            {
                return;
            }

            sd.sqlsave("update jan_tmr_approval_hist_t set project_code='" + txtfprojcode.Text + "',cost_center='" + txtfcstctr.Text + "',allocated_budget number='" + txtfallocbud.Text + "',finance_approved_by='" + txtfappby.Text + "',finance_head='" + txtfhead.Text + "'  where tmr_no='" + (String)Session["stmr"] + "'");
            ViewState["cmdsave6_Click"] = 0;
            ClientScript.RegisterStartupScript(this.GetType(), "alert", "alert('data updated...');", true);

        }

       

        }
}