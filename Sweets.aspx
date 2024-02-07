<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sweets.aspx.cs" Inherits="Template_Project.Page4" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sweets</title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/jquery.touchSwipe.min.js"></script>
    <script>
        $(function () {
            $("#form1").swipe(
                {
                    swipe: function (event, direction, distance, duration, fingerCount) {
                        if (direction == "left") {
                            window.location.href = "ContactUs.aspx"
                        }
                        else if (direction == "right") {
                            window.location.href = "Vegetables.aspx"
                        }
                    },
                    threshold: 100
                });
        });
     </script>
</head>

<body>    
    <form id="form1" runat="server" style="height:100vh; width:100vw">
        
        <div class ="row">            
            <div class="col-sm-2 offset-sm-1"  >
                <asp:LinkButton ID="LnkBtnMeats" runat="server" OnClick="LnkBtnMeats_Click">Meats</asp:LinkButton>            
            </div>
            <div class="col-sm-2">
                <asp:LinkButton ID="LnkBtnDairy" runat="server" OnClick="LnkBtnDairy_Click1">Dairy</asp:LinkButton>
            </div>
            <div class="col-sm-2">
                <asp:LinkButton ID="LnkBtnVeg" runat="server" OnClick="LnkBtnVeg_Click">Vegetables</asp:LinkButton>
            </div>
            <div class="col-sm-2">
                <asp:LinkButton ID="LnkBtnSweet" runat="server" OnClick="LnkBtnSweet_Click">Sweets</asp:LinkButton>
            </div>
            <div class="col-sm-2">
                <asp:LinkButton ID="LnkBtnContact" runat="server" OnClick="LnkBtnContact_Click">Contact Us</asp:LinkButton>
            </div>
        </div>
        
        <div>
            <asp:GridView ID="gridView1" runat="server" Width="100%" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="" HeaderText="" />
                    <asp:BoundField DataField="" HeaderText="" />
                    <asp:BoundField DataField="" HeaderText="" />
                    <asp:BoundField DataField="" HeaderText="" />
                    <asp:BoundField DataField="" HeaderText="" />
                </Columns>
            </asp:GridView>
        </div>

        <br />

        <div style="margin-left:auto; margin-right:auto; text-align:center;">
            <asp:Label ID="label1" runat="server" Text="LABEL"></asp:Label>
        </div>
        <div style="margin-left:auto; margin-right:auto; text-align:center;">
            <asp:Button ID="button1" runat="server" Text="BUTTON"/>
        </div>

    </form>
</body>
</html>
