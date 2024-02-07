<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnusedPage2.aspx.cs" Inherits="Template_Project.UnusedPage2" %>

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
                    tap: function () { },
                    doubleTap: function () {
                        window.location.href = "Page1.aspx"
                    }
                }

            );
        });
    </script>
</head>
<body>
    <form id="form1" runat="server" style="height:100vh; width:100vw">

    </form>
</body>
</html>
