<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ContactUs.aspx.cs" Inherits="Template_Project.Page5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact Us</title>
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
                            window.location.href = "Meat.aspx"
                        }
                        else if (direction == "right") {
                            window.location.href = "Sweets.aspx"
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
                <asp:LinkButton ID="LnkBtnDairy" runat="server" OnClick="LnkBtnDairy_Click">Dairy</asp:LinkButton>
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

        <br/>

         <div class="row">
            <div class="col-sm-6">
                        <asp:Label ID="Label1" runat="server" Text="LABEL"></asp:Label>
            </div>
            <div class="col-sm-6">
                        <asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
            </div>             
         </div>
         <br/>
         <div class="row">
            <div class="col-sm-6">
                        <asp:Label ID="Label2" runat="server" Text="LABEL"></asp:Label>
            </div>
            <div class="col-sm-6">
                        <asp:TextBox ID="textbox2" runat="server"></asp:TextBox>
            </div>
         </div>
         <br/>
         <div class="row">
            <div class="col-sm-6">
                        <asp:Label ID="Label3" runat="server" Text="LABEL"></asp:Label>
            </div>
            <div class="col-sm-6">
                        <asp:TextBox ID="textbox3" runat="server"></asp:TextBox>
            </div>
         </div>
         <br/>
         <div class="row">
            <div class="col-sm-6">
                        <asp:Label ID="Label4" runat="server" Text="LABEL"></asp:Label>
            </div>
            <div class="col-sm-6">
                        <asp:TextBox ID="textbox4" runat="server"></asp:TextBox>
            </div>
         </div>
        <br />
        <div class="row">
            <div class="col-sm-12">
                     <asp:Label ID="label5" runat="server" Text="LABEL"></asp:Label>
            </div>
        </div>
        <br />
        <div class="row">
            <div class="col-sm-12">
                     <asp:Button ID="button1" runat="server" Text="BUTTON"/>
             </div>
        </div>
    </form>
</body>
</html>
