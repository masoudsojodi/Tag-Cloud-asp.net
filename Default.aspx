<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Content/jquery-1.6.2.min.js"></script>
    <link href="Content/tag_cloud.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="tag-cloud">
    <%=_Model %>
    </div>
    </form>
</body>
    <script type="text/javascript">
  /*
    This is not necessary, but gives the tag-cloud a nice fade-in effect. 
  */
  $(document).ready(function onPageLoad() {
    var animatedProperties = {
      paddingLeft: '50px',
      paddingTop: '75px',
      paddingBottom: '125px',
      paddingRight: '150px',
      opacity: 1
    };

    $('.tag-cloud').animate(animatedProperties, 500);
  }); 
</script>
</html>
