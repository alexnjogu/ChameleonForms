﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChameleonForms.Templates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    
    #line 1 "..\..\Templates\HtmlHelpers.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Templates\HtmlHelpers.cshtml"
    using Enums;
    
    #line default
    #line hidden
    
    #line 3 "..\..\Templates\HtmlHelpers.cshtml"
    using Templates;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "1.4.1.0")]
    public static class HtmlHelpers
    {

public static System.Web.WebPages.HelperResult BeginForm(string action, FormMethod method, object htmlAttributes, EncType? enctype) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 8 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                              

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    ");



#line 9 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, HtmlWriter.BuildFormTag(action, method, htmlAttributes, enctype));

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\r\n");



#line 10 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult EndForm() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 12 "..\..\Templates\HtmlHelpers.cshtml"
                   

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    </form>\r\n");



#line 14 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BeginSection(string title, IHtmlString leadingHtml, object htmlAttributes) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 16 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                    

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    <fieldset>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        <legend>");



#line 18 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, title);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "</legend>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        ");



#line 19 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, leadingHtml);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        <dl");



#line 20 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, HtmlWriter.OutputAttributes(htmlAttributes));

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, ">\r\n");



#line 21 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BeginNestedSection(string title, IHtmlString leadingHtml, object htmlAttributes) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 23 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                          

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            <dt>");



#line 24 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, title);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "</dt>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            <dd>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                ");



#line 26 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, leadingHtml);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                <dl");



#line 27 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, HtmlWriter.OutputAttributes(htmlAttributes));

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, ">\r\n");



#line 28 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult EndSection() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 30 "..\..\Templates\HtmlHelpers.cshtml"
                      

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        </dl>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "    </fieldset>\r\n");



#line 33 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult EndNestedSection() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 35 "..\..\Templates\HtmlHelpers.cshtml"
                            

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                </dl>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            </dd>\r\n");



#line 38 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BeginFieldInternal(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 40 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                        

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            <dt>");



#line 41 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, labelHtml);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "</dt>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            <dd>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                ");



#line 43 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, elementHtml);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, " ");



#line 43 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, validationHtml);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\r\n");



#line 44 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult Field(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 46 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                           

#line default
#line hidden


#line 47 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml));

#line default
#line hidden


#line 47 "..\..\Templates\HtmlHelpers.cshtml"
                                                           

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            </dd>\r\n");



#line 49 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BeginField(IHtmlString labelHtml, IHtmlString elementHtml, IHtmlString validationHtml) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 51 "..\..\Templates\HtmlHelpers.cshtml"
                                                                                                

#line default
#line hidden


#line 52 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, BeginFieldInternal(labelHtml, elementHtml, validationHtml));

#line default
#line hidden


#line 52 "..\..\Templates\HtmlHelpers.cshtml"
                                                           

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                <dl>\r\n");



#line 54 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult EndField() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 56 "..\..\Templates\HtmlHelpers.cshtml"
                    

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "                </dl>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "            </dd>\r\n");



#line 59 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BeginNavigation() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 61 "..\..\Templates\HtmlHelpers.cshtml"
                           

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        <div class=\"form_navigation\">\r\n");



#line 63 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult EndNavigation() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 65 "..\..\Templates\HtmlHelpers.cshtml"
                         

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        </div>\r\n");



#line 67 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult BeginMessage(MessageType messageType, string heading) {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 68 "..\..\Templates\HtmlHelpers.cshtml"
                                                               

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "      <div class=\"");



#line 69 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, string.Format("{0}{1}", messageType.ToString().ToLower(), "_message"));

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "\">\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "        <h3>");



#line 70 "..\..\Templates\HtmlHelpers.cshtml"
WebViewPage.WriteTo(@__razor_helper_writer, heading);

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "</h3>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "          <div class=\"message\">\r\n");



#line 72 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


public static System.Web.WebPages.HelperResult EndMessage() {
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {



#line 74 "..\..\Templates\HtmlHelpers.cshtml"
                      

#line default
#line hidden

WebViewPage.WriteLiteralTo(@__razor_helper_writer, "          </div>\r\n");



WebViewPage.WriteLiteralTo(@__razor_helper_writer, "      </div>\r\n");



#line 77 "..\..\Templates\HtmlHelpers.cshtml"

#line default
#line hidden

});

}


    }
}
#pragma warning restore 1591
