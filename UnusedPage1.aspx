<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnusedPage1.aspx.cs" Inherits="Template_Project.UnusedPage1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.min.css" rel="stylesheet" />
    <script src="Scripts/jquery-3.0.0.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/popper.min.js"></script>
    <script src="Scripts/jquery.touchSwipe.min.js"></script>
    <script>
        $(function () {
            $('#form1').swipe(
                {
                    tap: function () {
                        window.location.href = "UnusedPage2.aspx"
                    }
                }

            );
        });
    </script>
</head>
<body>
    <form id="form1" runat="server" style="height:100vh; width:100vw">
        <div>
        </div>
    </form>
</body>
</html>
