<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication.Default" %>
<!DOCTYPE html>
<html>
    <head>
        <title>Default</title>
        <link href="//netdna.bootstrapcdn.com/twitter-bootstrap/2.2.1/css/bootstrap-combined.min.css" rel="stylesheet">
        <script src="//code.jquery.com/jquery-1.8.3.min.js" type="text/javascript"></script>
        <script src="//netdna.bootstrapcdn.com/twitter-bootstrap/2.2.1/js/bootstrap.min.js" type="text/javascript"></script>
		<script type="text/javascript">
			//var i;
			var clientError;

			$(document).ready(function () {
				//$('.combobox').combobox();


				$("#button").click(function () {
					$.getJSON("/Services/OrganizationService/Find?CostCenterCriteria=" + $("#input").val(), function (json) {
						$("#error").text("");
						$("#result").text(json);
					})
					.error(function (error) {
						clientError = error;
						$("#result").text("");
						$("#error").text(error.responseText);
					});



					//					var i = $.getJSON("/Services/OrganizationService/Find?CostCenterCriteria=X", function() {
					//						//Services/OrganizationService/Find?CostCenterCriteria=*
					//						alert("success");
					//					});
					//					//						.success(function () { alert("second success"); })
					//					//						.error(function () { alert("error"); })
					//					//						.complete(function () { alert("complete"); });

					//					//					// perform other work here ...

					//					//					// Set another completion function for the request above
					//					//					jqxhr.complete(function () { alert("second complete"); });

					//					alert(i);

					//					$("#result").text(i.responseText);
				});
			});
		</script>
    </head>
    <body>
		<h1>Default</h1>
		<h2>WCF service sample</h2>
		<p>Test with the following values:
			<ul>
				<li>WebFaultException</li>
				<li>FaultException</li>
				<li>Anything else</li>
			</ul>
		</p>
		<div>
			<p>
				<input id="input" type="text" />
				<button id="button" type="button">Button</button>
			</p>
			<div id="result" style="color: green;"></div>
			<div id="error" style="color: red;"></div>
		</div>
		<h2>No sample yet (for the select)</h2>
		<div>
			<asp:Repeater id="optionRepeater" DataSource="<%# this.Options %>" runat="server">
				<HeaderTemplate>
					<select class="combobox">
				</HeaderTemplate>
				<ItemTemplate>
					<option value="<%# ((KeyValuePair<string, string>) Container.DataItem).Key %>"><%# ((KeyValuePair<string, string>) Container.DataItem).Value %></option>
				</ItemTemplate>
				<FooterTemplate>
					</select>
				</FooterTemplate>
			</asp:Repeater>
		</div>
    </body>
</html>
