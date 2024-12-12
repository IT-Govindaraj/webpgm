<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="oraplm.addition" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
    function ShowPopup(title, body) {
        $("#myModal .modal-title").html(title);
        $("#myModal .modal-body").html(body);
        $("#myModal").modal("show");
    }
    function ShowPopup1(title, body) {
        $("#myModal1 .modal-title").html(title);
        $("#myModal1 .modal-body").html(body);
        $("#myModal1").modal("show");
    }
    function ShowPopup2(title, body) {
        $("#myModal2 .modal-title").html(title);
        $("#myModal2 .modal-body").html(body);
        $("#myModal2").modal("show");
    }
    function ShowPopup3(title, body) {
        $("#myModal3 .modal-title").html(title);
        $("#myModal3 .modal-body").html(body);
        $("#myModal3").modal("show");
    }
    function ShowPopup4(title, body) {
        $("#myModal4 .modal-title").html(title);
        $("#myModal4 .modal-body").html(body);
        $("#myModal4").modal("show");
    }
    function ShowPopup5(title, body) {
        $("#myModal5 .modal-title").html(title);
        $("#myModal5 .modal-body").html(body);
        $("#myModal5").modal("show");
        }
        function ShowPopup6(title, body) {
        $("#myModal6 .modal-title").html(title);
        $("#myModal6 .modal-body").html(body);
        $("#myModal6").modal("show");
        }
        function ShowPopup7(title, body) {
        $("#myModal7 .modal-title").html(title);
        $("#myModal7 .modal-body").html(body);
        $("#myModal7").modal("show");
    }
    //$('.datepicker').pickadate({
    //    // Escape any “rule” characters with an exclamation mark (!).
    //    format: 'dd-mmm-yyyy',
    //    formatSubmit: 'yyyy/mm/dd',
    //    hiddenPrefix: 'prefix__',
    //    hiddenSuffix: '__suffix'
    //})
    $('.txtedate').pickadate({
        weekdaysShort: ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'],
        showMonthsShort: true
        })


</script>
         <script type="text/javascript">
                    $(function () {
                            $('[id*=cmborg]').multiselect({
                                buttonClass: 'btn btn-warning',
                                buttonWidth: '260px',
                                enableFiltering: true,
                                enableCaseInsensitiveFiltering: true,
                                includeSelectAllOption: true
                            });
                    });
    </script>
     <script type="text/javascript">
                    $(function () {
                        $('[id*=cmborgbom]').multiselect({
                            buttonClass: 'btn btn-warning',
                            buttonWidth: '260px',
                            enableFiltering: true,
                            enableCaseInsensitiveFiltering: true,
                            includeSelectAllOption: true
                        });
                    });
    </script>
    <script>
                    $(function () {
                        $('[id*=txtfrm]').datepicker({
                            changeMonth: true,
                            changeYear: true,
                            format: "dd-M-yyyy",
                            language: "tr"
                        });
                    });
                    $(function () {
                        $('[id*=txtto]').datepicker({
                            changeMonth: true,
                            changeYear: true,
                            format: "dd-M-yyyy",
                            language: "tr"
                        });
                    });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
    <div class="input-group">
  
        <div class="input-group-prepend">
    <span class="input-group-text" id="">TMR No</span>
  </div>
<asp:TextBox ID="txttmr" runat="server"></asp:TextBox>
  <div class="input-group-prepend">
    <span class="input-group-text" id="">From</span>
  </div>
        <asp:TextBox ID="txtfrm" runat="server" Autocomplete="false"></asp:TextBox>
        <div class="input-group-prepend">
    <span class="input-group-text" id="">To</span>
  </div>
        <asp:TextBox ID="txtto" runat="server" Autocomplete="false"></asp:TextBox>
<asp:Button ID="cmdshow" runat="server" Text="Show" CssClass="form-control bg-secondary text-white" OnClick="cmdshow_Click" />
        <asp:Button ID="cmdbuy" CssClass="form-control bg-primary text-white" runat="server" Text="Buy Tool Request" OnClick="cmdbuy_Click" />
            </div>
</div>        
        <div class="row">
            <div class="col-12">
<asp:DataGrid ID="grid1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="#FF6600" BorderColor="#999999" BorderStyle="Solid" CellPadding="2" CssClass="table table-condensed h5" ShowFooter="True" Width="100%" HorizontalAlign="Left" BorderWidth="1px" OnItemCommand="grid1_ItemCommand">
                    <Columns>
                        <asp:BoundColumn DataField="tmr_no" HeaderText="TMR No"></asp:BoundColumn>
                        <asp:BoundColumn DataField="tmr_date" HeaderText="TMR Date"></asp:BoundColumn>
                        <asp:BoundColumn DataField="request_reason" HeaderText="Reason"></asp:BoundColumn>
                        <asp:BoundColumn DataField="product_no" HeaderText="Product No"></asp:BoundColumn>
                        <asp:BoundColumn DataField="tool_no" HeaderText="Tool No"></asp:BoundColumn>
                        <asp:BoundColumn DataField="tool_type" HeaderText="Tool Type"></asp:BoundColumn>
                        <asp:ButtonColumn HeaderText="Approval&lt;br&gt;(Design)" Text="Appove" CommandName="deapprove"></asp:ButtonColumn>
                        <asp:ButtonColumn HeaderText="Approval&lt;br&gt;(Tool Room)" Text="Approve" CommandName="tlapprove"></asp:ButtonColumn>
                        <asp:ButtonColumn HeaderText="Approval&lt;br&gt;(Materials/Prodn)" Text="Approve" CommandName="mtapprove"></asp:ButtonColumn>
                        <asp:ButtonColumn HeaderText="Approval&lt;br&gt;(Quality)" Text="Approve" CommandName="qapprove"></asp:ButtonColumn>
                        <asp:ButtonColumn HeaderText="Approval&lt;br&gt;(Costing)" Text="Approve" CommandName="capprove"></asp:ButtonColumn>
                        <asp:ButtonColumn HeaderText="Approval&lt;br&gt;(Design DBMS)" Text="Approve" CommandName="dbmsapprove"></asp:ButtonColumn>
                        <asp:ButtonColumn HeaderText="Approval&lt;br&gt;(Finance)" Text="Approve" CommandName="finapprove"></asp:ButtonColumn>
                        <asp:BoundColumn DataField="data_upd_cnt" HeaderText="data_upd_cnt" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="stage1" HeaderText="Stage1" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="stage2" HeaderText="Stage2" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="stage3" HeaderText="Stage3" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="stage4" HeaderText="Stage4" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="stage5" HeaderText="Stage5" Visible="False"></asp:BoundColumn>
                        <asp:BoundColumn DataField="stage6" HeaderText="Stage6" Visible="False"></asp:BoundColumn>
                        <asp:ButtonColumn CommandName="Print" HeaderText="Print" Text="Print"></asp:ButtonColumn>
                    </Columns>
                    <FooterStyle BackColor="White" ForeColor="#000066" BorderColor="White" HorizontalAlign="Left" BorderStyle="Solid" BorderWidth="0px" />
                    <SelectedItemStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" Mode="NumericPages" />
                    <AlternatingItemStyle BackColor="#E5E5E5" BorderWidth="0px" ForeColor="Black" />
                    <ItemStyle BackColor="White" ForeColor="#003366" BorderStyle="None" />
                    <HeaderStyle BackColor="#EFEFEF" Font-Bold="True" Font-Italic="False" Font-Overline="False" Font-Strikeout="False" Font-Underline="False" ForeColor="#454545" />
                </asp:DataGrid>

                <div class="modal modal-child" id="myModal" data-toggle="modal" data-backdrop-limit="1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog" style="max-width:1000px; max-height:1000px;">
      <div class="modal-content">
      
        <!-- Modal Header -->
        <div class="modal-header">
          <h1 class="modal-title">Approval - Design</h1>
          <button type="button" class="close" data-dismiss="modal">×</button>
        </div>
        
        <!-- Modal body -->
        <div class="modal-body">
            <h5>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Tool cost prescribed by Tool Room : </label>
                            <div class="col-sm-8">
                             <asp:TextBox ID="txttoolcost" class="form-control" runat="server" placeholder="Tool cost prescribed by Tool Room"></asp:TextBox>
                             </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Quote by the supplier : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtquote" class="form-control" runat="server" placeholder="Quote by the supplier"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Tool Budgeted Product Development Cost : </label>
                        <div class="col-sm-8">
                        <asp:TextBox ID="txtpdcost" class="form-control" runat="server" placeholder="Tool Budgeted Product Development Cost"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Tool cost included in budget Y/N : </label>
                        <div class="col-sm-8">
                        <asp:TextBox ID="txtbudcost" class="form-control" runat="server" placeholder="Tool cost included in budget Y/N"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Remark  : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtdremrk" class="form-control" runat="server" placeholder="Remark"></asp:TextBox>
                            </div>
                    </div>
                
                    <p>&nbsp;<asp:RadioButton ID="dr1" Text="(a)We have tool cost in our development cost and can be proceed for Tool Manufacturing or Procurement of Tool from supplier" runat="server" /></p>
                    <p>&nbsp;<asp:RadioButton ID="dr2" Text="(b)Noted, there is No proposal for design modification in the referred component.Hence New /Additional tool request can be preceded" runat="server" /></p>
                    <p>&nbsp;<asp:RadioButton ID="dr3" Text="(c)Verified the proposed design changes, after verification / Validation the proposed changes are ACCEPTED and proceed with the attached new design" runat="server" /></p>
                    <p>&nbsp;<asp:RadioButton ID="dr4" Text="(d)Verified the proposed design changes, after verification / Validation the proposed changes are NOT ACCEPTED since it will affect the product performance.Hence the tool can be manufactured as per prevailing design alone" runat="server" /></p>
                    <p style="text-align:right">Approved By</p>
                    <p style="text-align:right"><asp:TextBox ID="txtdappby" class="form-control-lg" runat="server" placeholder="Approved By"></asp:TextBox></p>
                    <p style="text-align:right">Head - Design</p>
                    <p style="text-align:right"><asp:TextBox ID="txtdhead" class="form-control-lg" runat="server" placeholder="Design Head"></asp:TextBox></p>
            
                <asp:Button ID="cmdsave" CssClass="btn-secondary text-white" runat="server" Text="Save"   OnClick="cmdsave_Click" />
            </h5>
            
        </div>
        <!-- Modal footer -->
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
        </div>
        
      </div>
    </div>
  </div>
                <div class="modal modal-child" id="myModal1" data-toggle="modal" data-backdrop-limit="1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog" style="max-width:1000px; max-height:1000px;">
      <div class="modal-content">
      
        <!-- Modal Header -->
        <div class="modal-header">
          <h1 class="modal-title">Approval - ToolRoom</h1>
          <button type="button" class="close" data-dismiss="modal">×</button>
        </div>
        
        <!-- Modal body -->
        <div class="modal-body">
            <h5>
                     <div class="form-group row">
                          <label for="staticEmail" class="col-sm-4 col-form-label right">Tool Request No : </label>
                        <div class="col-sm-8">
                       <asp:TextBox ID="txttoolreqno" class="form-control" runat="server" placeholder="Tool Request No"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Part No : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtpartno" class="form-control" runat="server" placeholder="Part No"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Description : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtdesc" class="form-control" runat="server" placeholder="Description"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Estimated Tool Cost : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txttoolest" class="form-control" runat="server" placeholder="Estimated Tool Cost"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Estimated Tool life : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtesttoollife" class="form-control" runat="server" placeholder="Estimated Tool life"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Present Tool Life : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtptoollife" class="form-control" runat="server" placeholder="Present Tool Life"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Present No of Cavity : </label>
                        <div class="col-sm-8">
                        <asp:TextBox ID="txtpnocav" class="form-control" runat="server" placeholder="Present No of Cavity"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Remarks : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txttremrk" class="form-control" runat="server" placeholder="Remarks"></asp:TextBox>
                            </div>
                    </div>
                
                    <p><asp:RadioButton ID="tr1" Text="(a)As per the Tool Manufacturing Request we have verified the drawing and propose to manufacture tool as per above information. Kindly include the Tool Cost in the Development cost of the Product" runat="server" /></p>
                    <p><asp:RadioButton ID="tr2" Text="(b)Since the life of present tool is exhausted, we propose to manufacture new tool with Same configuration. If any design changes proposal is planned (or) Specific Quality requirement in this component kindly discuss and revise the drawing to incorporate the changes in New tool" runat="server" /></p>
                    <p><asp:RadioButton ID="tr3" Text="(c)Since the life of present tool is exhausted, we propose to manufacture new tool with increased no of Cavity from _______ to _______  to meet the increased production. If any design change proposal is planned (or) Specific Quality requirement in this component kindly discuss and revise the drawing to incorporate the changes in New tool" runat="server" /></p>
                    <p><asp:RadioButton ID="tr4" Text="(d)We have plan to manufacture new tool due to major damages / break down found in the existing tool. If any design change proposal is planned (or) Specific Quality requirement in this component kindly discuss and revise the drawing to incorporate the changes in New tool" runat="server" /></p>
                    <p><asp:RadioButton ID="tr5" Text="(e)Our estimated the Tool Cost as per supplier Planned configuration is Rs ___________________ /- Kindly restrict the Buying price of the tool cost as above" runat="server" /></p>
                    <p style="text-align:right">Approved By</p>
                    <p style="text-align:right"><asp:TextBox ID="txtappby" class="form-control-lg" runat="server" placeholder="Approved By"></asp:TextBox></p>
                    <p style="text-align:right">Head - Tool Room</p>
                    <p style="text-align:right"><asp:TextBox ID="txtthead" class="form-control-lg" runat="server" placeholder="Head Tool Room"></asp:TextBox></p>
                    <asp:Button ID="cmdsave1" CssClass="btn-secondary text-white" runat="server" Text="Save"   OnClick="cmdsave1_Click" />
            </h5>
        </div>
        <!-- Modal footer -->
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
        </div>
        
      </div>
    </div>
  </div>
                <div class="modal modal-child" id="myModal2" data-toggle="modal" data-backdrop-limit="1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog" style="max-width:1000px; max-height:1000px;">
      <div class="modal-content">
      
        <!-- Modal Header -->
        <div class="modal-header">
          <h1 class="modal-title">Approval - Material/Production</h1>
          <button type="button" class="close" data-dismiss="modal">×</button>
        </div>
        
        <!-- Modal body -->
        <div class="modal-body">
            <h5>
                     <div class="form-group row">
                            <label for="staticEmail" class="col-sm-4 col-form-label right">Present Stock : </label>
                        <div class="col-sm-8">
                        <asp:TextBox ID="txtstock" class="form-control" runat="server" placeholder="Present Stock"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                           <label for="staticEmail" class="col-sm-4 col-form-label right">Optimum Qty / Month : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtoptimum" class="form-control" runat="server" placeholder="Optimum Qty / Month"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                           <label for="staticEmail" class="col-sm-4 col-form-label right">DDS Shortage : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtddsshort" class="form-control" runat="server" placeholder="DDS Shortage"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                           <label for="staticEmail" class="col-sm-4 col-form-label right">PO Pending : </label>
                        <div class="col-sm-8">
                        <asp:TextBox ID="txtpopend" class="form-control" runat="server" placeholder="PO Pending"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                           <label for="staticEmail" class="col-sm-4 col-form-label right">No of Suppliers : </label>
                        <div class="col-sm-8">
                       <asp:TextBox ID="txtnos" class="form-control" runat="server" placeholder="No of Suppliers"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                           <label for="staticEmail" class="col-sm-4 col-form-label right">Tentative increase in consider previous year : </label>
                        <div class="col-sm-8">
                        <asp:TextBox ID="txttentinc" class="form-control" runat="server" placeholder="Tentative increase in consider previous year"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                           <label for="staticEmail" class="col-sm-4 col-form-label right">Remarks : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtpremrk" class="form-control" runat="server" placeholder="Remarks"></asp:TextBox>
                            </div>
                    </div>
                
                    <p><asp:RadioButton ID="pr1" Text="(a)Due to increase in production, we are unable to supply as per demand. Hence please supply additional tool to ensure on-time delivery of the component" runat="server" /></p>
                    <p><asp:RadioButton ID="pr2" Text="(b)Due to increase in production, we are unable to supply as per demand. Hence please increase the no of cavity in the present tool to ensure on-time delivery of the component" runat="server" /></p>
                    <p><asp:RadioButton ID="pr3" Text="(c)Due to the exhausting life of present tool, please supply the new tool to ensure on time delivery of parts." runat="server" /></p>
                    <p><asp:RadioButton ID="pr4" Text="(d)Due to repeated quality rejections and as per QA Analysis, please supply the new tool to ensure on time delivery of components" runat="server" /></p>
                    <p><asp:RadioButton ID="pr5" Text="(e)Verified the proposal, and recommended to increase the no of cavity in the tool due to increased qty." runat="server" /></p>
                    <p style="text-align:right">Approved By</p>
                     <p style="text-align:right"><asp:TextBox ID="txtpappby" class="form-control-lg" runat="server" placeholder="Approved By"></asp:TextBox></p>
                    <p style="text-align:right">Head - Materials</p>
                     <p style="text-align:right"><asp:TextBox ID="txtmhead" class="form-control-lg" runat="server" placeholder="Head Materials"></asp:TextBox></p>
       <asp:Button ID="cmdsave2" CssClass="btn-secondary text-white" runat="server" Text="Save"   OnClick="cmdsave2_Click" />
            </h5>
        </div>
        <!-- Modal footer -->
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
        </div>
        
      </div>
    </div>
  </div>
                <div class="modal modal-child" id="myModal3" data-toggle="modal" data-backdrop-limit="1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog" style="max-width:1000px; max-height:1000px;">
      <div class="modal-content">
      
        <!-- Modal Header -->
        <div class="modal-header">
          <h1 class="modal-title">Approval - Quality</h1>
          <button type="button" class="close" data-dismiss="modal">×</button>
        </div>
        
        <!-- Modal body -->
        <div class="modal-body">
            <h5>
                     <div class="form-group row">
                          <label for="staticEmail" class="col-sm-4 col-form-label right">Current Rejetion PPM of this component : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtrejppm" class="form-control" runat="server" placeholder="Current Rejetion PPM of this component"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">No of Customer Complaint Received due to this Component : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtnocuscomp" class="form-control" runat="server" placeholder="No of Customer Complaint Received due to this Component"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Remarks : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtqremrk" class="form-control" runat="server" placeholder="Remarks"></asp:TextBox>
                        </div>
                    </div>                   
                    <p><asp:RadioButton ID="qr1" Text="(a)Due to repeated rejections please manufacture the new tool to overcome Critical Parameters mentioned in the attached. Also please ensure no deviation in the critical dimensions to restrict the rejection of this component / complaints due to this part." runat="server" /></p>
                    <p><asp:RadioButton ID="qr2" Text="(b)To resolve the customer complaint, New tool can be manufactured to overcome the quality issue. Refer attached Root Cause Analysis / Customer Complaint Analysis for information" runat="server" /></p>
                    <p><asp:RadioButton ID="qr3" Text="(c)We have verified the Additional tool request and No concern with quality requirement and proceed" runat="server" /></p>
                    <p><asp:RadioButton ID="qr4" Text="(d)We have proposed the design changes and design department accepts our proposal and issued new drawing. Kindly manufacture the tool as per new drawing to reduce rejection / Failures" runat="server" /></p>
                    <p style="text-align:right">Approved By</p>
                    <p style="text-align:right"><asp:TextBox ID="txtqappby" class="form-control-lg" runat="server" placeholder="Approved by"></asp:TextBox></p>
                    <p style="text-align:right">Head - Quality</p>
                    <p style="text-align:right"><asp:TextBox ID="txtqhead" class="form-control-lg" runat="server" placeholder="Head - Quality"></asp:TextBox></p>
             <asp:Button ID="cmdsave3" CssClass="btn-secondary text-white" runat="server" Text="Save"   OnClick="cmdsave3_Click" />
            </h5>
        </div>
        <!-- Modal footer -->
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
        </div>
        
      </div>
    </div>
  </div>
                <div class="modal modal-child" id="myModal4" data-toggle="modal" data-backdrop-limit="1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog" style="max-width:1000px; max-height:1000px;">
      <div class="modal-content">
      
        <!-- Modal Header -->
        <div class="modal-header">
          <h1 class="modal-title">Approval - Costing</h1>
          <button type="button" class="close" data-dismiss="modal">×</button>
        </div>
        
        <!-- Modal body -->
        <div class="modal-body">
            <h5>
                     <div class="form-group row">
                          <label for="staticEmail" class="col-sm-4 col-form-label right">Present Buying / Process cost of component : </label>
                        <div class="col-sm-8">
                         <asp:TextBox ID="txtpbcst" class="form-control" runat="server" placeholder="Present Buying / Process cost of component"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Estimated Component cost as per Proposal : </label>
                        <div class="col-sm-8"> 
                        <asp:TextBox ID="txtestcostpro" class="form-control" runat="server" placeholder="Estimated Component cost as per Proposal"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Estimated Tool Cost as per Tool Room : </label>
                        <div class="col-sm-8"> 
                        <asp:TextBox ID="txtctoolcst" class="form-control" runat="server" placeholder="Estimated Tool Cost as per Tool Room"></asp:TextBox>
                       </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Changes in Total cost due to new tool : </label>
                        <div class="col-sm-8">
                        <asp:TextBox ID="txtnewtoolcst" class="form-control" runat="server" placeholder="Changes in Total cost due to new tool"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Remarks : </label>
                        <div class="col-sm-8">
                        <asp:TextBox ID="txtcremrk" class="form-control" runat="server" placeholder="Remarks"></asp:TextBox>
                            </div>
                    </div>
                    <p><asp:RadioButton ID="cr1" Text="(a)Verified the Tool Manufacturing Request, and inclusion of tool cost in the product development cost. Kindly proceed to start manufacturing of tool" runat="server" /></p>
                    <p><asp:RadioButton ID="cr2" Text="(b)Verified the existing life of tool and proceed for new tool as per request of Tool Room / Materials / Production" runat="server" /></p>
                    <p><asp:RadioButton ID="cr3" Text="(c)Cost will be reduced by Rs ___________ as per Proposed tool (Increase of Cavity / Extrusion to Molding). The payback of tool is ____________________ and proceed" runat="server" /></p>
                    <p><asp:RadioButton ID="cr4" Text="(d)Verified the FRDS Rejection / Customer complaint Reports / Inwards Rejection of component. Kindly proceed for new tool to over the quality issues" runat="server" /></p>
                    <p><asp:RadioButton ID="cr5" Text="(e)Verified the increased demand of component and proceed for new / additional tool to meet the requirement" runat="server" /></p>
                    <p><asp:RadioButton ID="cr6" Text="(f)Verified the Tool cost and component cost, proceed to buy the tool as per tool room proposed tooling cost Rs __________________________" runat="server" /></p>
                    <p><asp:RadioButton ID="cr7" Text="(g)As per the proposal of Materials department the tooling cost will be amortized over ______________Qty. After supplying of stipulated quantities the rate will be reduced." runat="server" /></p>
                    <p style="text-align:right">Approved By</p>
            <p style="text-align:right"><asp:TextBox ID="txtcappby" class="form-control-lg" runat="server" placeholder="Approved By"></asp:TextBox></p>
                    <p style="text-align:right">Head - Costing</p>
            <p style="text-align:right"><asp:TextBox ID="txtchead" class="form-control-lg" runat="server" placeholder="Head - Costing"></asp:TextBox></p>
             <asp:Button ID="cmdsave4" CssClass="btn-secondary text-white" runat="server" Text="Save"   OnClick="cmdsave4_Click" />
            </h5>
        </div>
        <!-- Modal footer -->
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
        </div>
        
      </div>
    </div>
  </div>
                <div class="modal modal-child" id="myModal5" data-toggle="modal" data-backdrop-limit="1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog" style="max-width:1000px; max-height:1000px;">
      <div class="modal-content">
      
        <!-- Modal Header -->
        <div class="modal-header">
          <h1 class="modal-title">Approval -(Design - DBMS)</h1>
          <button type="button" class="close" data-dismiss="modal">×</button>
        </div>
        
        <!-- Modal body -->
        <div class="modal-body">
            <h5>
                     <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Tool No Allocated as : </label>
                        <div class="col-sm-8"> 
                         <asp:TextBox ID="txttalloc" class="form-control" runat="server" placeholder="Tool No Allocated as"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Status of Existing tool : </label>
                        <div class="col-sm-8"> 
                        <asp:TextBox ID="txtetoolstat" class="form-control" runat="server" placeholder="Status of Existing tool"></asp:TextBox>
                            </div>
                    </div>
                    <p><asp:RadioButton ID="dbr1" Text="Above tool no is allocated as per Tool Manufacturing Request" runat="server" /></p>
                    <p style="text-align:right">Updated By</p>
                    <p style="text-align:right"><asp:TextBox ID="txtdbmsupdby" class="form-control-lg" runat="server" placeholder="Updated By"></asp:TextBox></p>
                    <p style="text-align:right">Oracle – DBMS Team</p>
                    <p style="text-align:right"><asp:TextBox ID="txtteamoradbms" class="form-control-lg" runat="server" placeholder="Oracle – DBMS Team"></asp:TextBox></p>
             <asp:Button ID="cmdsave5" CssClass="btn-secondary text-white" runat="server" Text="Save"   OnClick="cmdsave5_Click" />
            </h5>
        </div>
        <!-- Modal footer -->
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
        </div>
        
      </div>
    </div>
  </div>
                <div class="modal modal-child" id="myModal6" data-toggle="modal" data-backdrop-limit="1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog" style="max-width:1000px; max-height:1000px;"> 
      <div class="modal-content">
      
        <!-- Modal Header -->
        <div class="modal-header">
          <h1 class="modal-title">Approval -(Finance)</h1>
          <button type="button" class="close" data-dismiss="modal">×</button>
        </div>
        
        <!-- Modal body -->
        <div class="modal-body">
            <h5>
                     <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Project Code : </label>
                        <div class="col-sm-8"> 
                          <asp:TextBox ID="txtfprojcode" class="form-control" runat="server" placeholder="Project Code"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Cost Centre : </label>
                        <div class="col-sm-8"> 
                          <asp:TextBox ID="txtfcstctr" class="form-control" runat="server" placeholder="Cost Centre"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Allocated Budget : </label>
                        <div class="col-sm-8">     
                        <asp:TextBox ID="txtfallocbud" class="form-control" runat="server" placeholder="Allocated Budget"></asp:TextBox>
                        </div>
                    </div>
                    
                    <p style="text-align:right">Approved By</p>
                    <p style="text-align:right"><asp:TextBox ID="txtfappby" class="form-control-lg" runat="server" placeholder="Approved By"></asp:TextBox></p>
                    <p style="text-align:right">Head – Finance</p>
                    <p style="text-align:right"><asp:TextBox ID="txtfhead" class="form-control-lg" runat="server" placeholder="Head – Finance"></asp:TextBox></p>
             <asp:Button ID="cmdsave6" CssClass="btn-secondary text-white" runat="server" Text="Save"   OnClick="cmdsave6_Click" />
            </h5>
        </div>
        <!-- Modal footer -->
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
        </div>
        
      </div>
    </div>
  </div>

                <div class="modal modal-child" id="myModal7" data-toggle="modal" data-backdrop-limit="1" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
    <div class="modal-dialog" style="max-width:1000px; max-height:1000px;"> 
      <div class="modal-content">
      
        <!-- Modal Header -->
        <div class="modal-header">
          <h1 class="modal-title">Tool Request (Buy)</h1>
          <button type="button" class="close" data-dismiss="modal">×</button>
        </div>
        
        <!-- Modal body -->
        <div class="modal-body">
            <h5>
                     <div class="form-group row">
                         <label for="staticEmail" class="col-sm-4 col-form-label right">Org : </label>
                        <div class="col-sm-8"> 
                         <asp:DropDownList ID="cmborg" runat="server">
                             <asp:ListItem></asp:ListItem>
                             
                         </asp:DropDownList>

                        </div>
                         
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Part No : </label>
                        <div class="col-sm-8"> 
                          <asp:TextBox ID="txtpart" class="form-control" runat="server" placeholder="Part No"></asp:TextBox>
                            </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Description : </label>
                        <div class="col-sm-8">     
                        <asp:TextBox ID="txtpartdesc" class="form-control" runat="server" placeholder="Description"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Product No : </label>
                        <div class="col-sm-8">     
                        <asp:TextBox ID="txtprod" class="form-control" runat="server" placeholder="Product No"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Description : </label>
                        <div class="col-sm-8">     
                        <asp:TextBox ID="txtproddesc" class="form-control" runat="server" placeholder="Description"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Type of Tool : </label>
                        <div class="col-sm-8">     
                            <asp:DropDownList ID="cmbttype" runat="server">
                                <asp:ListItem></asp:ListItem>
                                <asp:ListItem>PDC</asp:ListItem>
                                <asp:ListItem>GDC</asp:ListItem>
                                <asp:ListItem>PLM</asp:ListItem>
                                <asp:ListItem>RBM</asp:ListItem>
                                <asp:ListItem>Extrusion</asp:ListItem>
                                <asp:ListItem>Forging Die</asp:ListItem>
                                <asp:ListItem>GDC-Die</asp:ListItem>
                                <asp:ListItem>Inj. Moulds</asp:ListItem>
                                <asp:ListItem>Inj. Moulds RandD</asp:ListItem>
                                <asp:ListItem>Inv. Casting</asp:ListItem>
                                <asp:ListItem>Packing Box Die</asp:ListItem>
                                <asp:ListItem>Patterns</asp:ListItem>
                                <asp:ListItem>PDC-Die</asp:ListItem>
                                <asp:ListItem>Press Tool</asp:ListItem>
                                <asp:ListItem>Rubber-Die </asp:ListItem>
                                <asp:ListItem>Others</asp:ListItem>
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">No of Cavity : </label>
                        <div class="col-sm-8">     
                        <asp:TextBox ID="txtnocav" class="form-control" runat="server" placeholder="No of Cavity"></asp:TextBox>
                        </div>
                    </div>
                    <div class="form-group row">
                        <label for="staticEmail" class="col-sm-4 col-form-label right">Supplier Name : </label>
                        <div class="col-sm-8">     
                        <asp:TextBox ID="txtsupp" class="form-control" runat="server" placeholder="Supplier Name"></asp:TextBox>
                        </div>
                    </div>
                    
             <asp:Button ID="cmdupd" CssClass="btn-secondary text-white" runat="server" Text="Save"   OnClick="cmdupd_Click" />
            </h5>
        </div>
        <!-- Modal footer -->
        <div class="modal-footer">
          <button type="button" class="btn btn-danger" data-dismiss="modal">Close</button>
        </div>
        
      </div>
    </div>
  </div>

            </div>
        </div>
</asp:Content>
