using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oraplm
{
    public partial class print : System.Web.UI.Page
    {
        sqldata sd = new sqldata();
        DataSet ds = new DataSet();
        String s = String.Empty;
        protected void Page_Load(object sender, EventArgs e)
        {
            ds = (DataSet)Session["spds"];
            s = "";

            s = "<html><head>";
            s = s + "<style type=text/css>";
            s = s + ".tabr { font-family: ARIAL;font-size: 8pt;color:black}";
            s = s + ".tab { font-family: ARIAL;font-size: 9pt;color:Blue}";
            s = s + ".tab1 { font-family: verdana;font-size: 9pt;background-color:white;color:black;font-weight:bold;}";
            s = s + ".tab2 { font-family: verdana;font-size: 9pt;font-weight:bold;}";
            s = s + ".tab3 { font-family: verdana;font-size: 7pt;color:blue;}";
            s = s + ".tabsm { font-family: verdana;font-size: 5pt;color:blue;}";
            s = s + ".hr {border: 2px dashed #000;}";
            s = s + "</style>";


            s += "<table border=1 width=100% cellspacing=0 cellpadding=0 class=tab>";
            s += "<tr>";
          
            s += "<td colspan=2 align=center>";

            s += "<b>TMR Dept Wise Approval Status</b>";

            s += "</td>";

            s += "</tr>";


            foreach (DataRow Title in ds.Tables[0].Rows)
            {
                s += "<table border=1 width=100% cellspacing=0 cellpadding=0 class=tab>";
                s += "<tr>";

                s += "<td colspan=2 align=center>";

                s += "<b>Approval - Design</b>";

                s += "<hr>";

                s += "</td>";

                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Tool Cost Precribed by ToolRoom</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["PRESCRIBED_TOOL_COST"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Quote by the supplier</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["SUPPLIER_QUOTE"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Tool Budgeted Product development cost</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["PRODUCT_DEVELOPMENT_COST"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Tool Cost included in Budget(Y/N)</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["TOOL_COST_INCLUSION_BUDGET"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Remarks</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["DESIGN_REMARKS"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Approved by</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["DESIGN_APPROVED_BY"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Head Design</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["DESIGN_HEAD"]) + "</td>";
                s += "</tr>";

                s += "</table>";


                s += "<table border=1 width=100% cellspacing=0 cellpadding=0 class=tab>";
                s += "<tr>";

                s += "<td colspan=2 align=center>";

                s += "<b>Approval - ToolRoom</b>";

                s += "</td>";

                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Tool Request No</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["TOOL_REQUEST_NO"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Part No</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["ITEM_NO"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Description</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["DESCRIPTION"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Estimted Tool cost</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["TOOLROOM_ESTIMATED_TOOL_COST"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Estimated Tool life</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["TOOLROOM_ESTIMATED_TOOL_LIFE"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Present Tool life</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["PRESENT_TOOL_LIFE"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Present No of Cavity</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["PRESENT_NO_OF_CAVITY"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Remarks</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["TOOL_ROOM_REMARKS"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Remarks</td>";
                s += "<td>";
                s += "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Approved by</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["TOOLROOM_APPROVED_BY"]) + "</td>";
                s += "</tr>";

                s += "<tr>";
                s += "<td>";
                s += "Head - ToolRoom</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["TOOLROOM_HEAD"]) + "</td>";
                s += "</tr>";
                s += "</table>";

                s += "<table border=1 width=100% cellspacing=0 cellpadding=0 class=tab>";
                s += "<tr>";

                s += "<td colspan=2 align=center>";

                s += "<b>Approval - Materials/Prodn</b>";

                s += "</td>";

                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Present Stock</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["PRESENT_STOCK"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Optimum Qty/Month</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["OPTIMUM_QTY"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "DDS Shortage</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["DDS_SHORTAGE"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "PO Pending</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["PO_PENDING"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "No of Suppliers</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["NO_OF_SUPPLIERS"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Tentative increase in consider previous year</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["TENTATIVE_INCREASE"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Remarks</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["MATERIALS_REMARKS"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Remarks</td>";
                s += "<td>";
                s += "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Approved By</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["MATERIALS_APPROVED_BY"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Head - Materials</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["MATERIALS_HEAD"]) + "</td>";
                s += "</tr>";
                s += "</table>";


                s += "<table border=1 width=100% cellspacing=0 cellpadding=0 class=tab>";
                s += "<tr>";

                s += "<td colspan=2 align=center>";

                s += "<b>Approval - Quality</b>";

                s += "</td>";

                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Current Rejection PPM of this component</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["CURRENT_REJECTION_PPM"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "No of Customer complaints received due to this component</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["NO_OF_CUSTOMER_COMPLAINTS_COMPONENT"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Remarks</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["QUALITY_REMARKS"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Remarks</td>";
                s += "<td>";
                s += "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Approved by</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["QUALITY_REMARKS"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Head - Quality</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["QUALITY_REMARKS"]) + "</td>";
                s += "</tr>";
                s += "</table>";

                s += "<table border=1 width=100% cellspacing=0 cellpadding=0 class=tab>";
                s += "<tr>";

                s += "<td colspan=2 align=center>";

                s += "<b>Approval - Costing</b>";

                s += "</td>";

                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Present Buying/Process cost of component</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["PRESENT_PROCESS_COST"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Estimated component cost as per proposal</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["ESTIMATED_COMPONENT_COST_PROPOSAL"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Estimated Tool cost as per toolroom</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["ESTIMATED_TOOL_COST"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Changes in total cost due to new tool</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["TOTAL_NEW_TOOL_CHANGE_COST"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Remarks</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["COSTING_REMARKS"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Remarks</td>";
                s += "<td>";
                s += "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Approved by</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["COSTING_APPROVED_BY"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Head - Costing</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["COSTING_HEAD"]) + "</td>";
                s += "</tr>";
                s += "</table>";

                s += "<table border=1 width=100% cellspacing=0 cellpadding=0 class=tab>";
                s += "<tr>";

                s += "<td colspan=2 align=center>";

                s += "<b>Approval - Design DBMS</b>";

                s += "</td>";

                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Tool No Allocated as</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["TOOL_NO_ALLOCATED"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Status of Existing tool</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["STATUS_OF_EXISTING_TOOL"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Remarks</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["STATUS_OF_EXISTING_TOOL"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Updated by</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["DBMS_UPDATED_BY"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Oracle - DBMS Team</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["ORACLE_DBMS_TEAM"]) + "</td>";
                s += "</tr>";
                s += "</table>";

                s += "<table border=1 width=100% cellspacing=0 cellpadding=0 class=tab>";
                s += "<tr>";

                s += "<td colspan=2 align=center>";

                s += "<b>Approval - Finance</b>";

                s += "</td>";

                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Project code</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["PROJECT_CODE"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Cost center</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["COST_CENTER"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Allocated Budget</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["ALLOCATED_BUDGET"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Approved By</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["FINANCE_APPROVED_BY"]) + "</td>";
                s += "</tr>";
                s += "<tr>";
                s += "<td>";
                s += "Head - Finance</td>";
                s += "<td>";
                s += "" + Convert.ToDouble(Title["FINANCE_HEAD"]) + "</td>";
                s += "</tr>";
                s += "</table>";

            }
            Response.Output.Write(s);

            }
    }
}