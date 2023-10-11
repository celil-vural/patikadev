import{a as c}from"../../../../_chunks/chunk-DU2FOE4V.js";import{a as s}from"../../../../_chunks/chunk-HV6C77RL.js";import{a,b as d,e as m,f as g}from"../../../../_chunks/chunk-ZR7A2VZA.js";var u=d(m(),1),e=d(g(),1);$(function(){var n,r,o;var i=new l($("#LoginPanel")).init();i.element.find(".forgot-password").appendTo(".field.Password"),(n=document.getElementById("IsPublicDemo"))!=null&&n.value&&(i.byId("Username").val("admin").attr("placeholder","admin"),i.byId("Password").val("serenity").attr("placeholder","serenity")),(r=document.getElementById("Activated"))!=null&&r.value&&(i.byId("Username").val((o=document.getElementById("Activated"))==null?void 0:o.value),i.byId("Password").focus())});var l=class extends u.PropertyPanel{getFormKey(){return c.formKey}constructor(n){super(n),this.byId("LoginButton").click(r=>{if(r.preventDefault(),!!this.validateForm()){var o=this.getSaveEntity();(0,e.serviceCall)({url:(0,e.resolveUrl)("~/Account/Login"),request:o,onSuccess:()=>{this.redirectToReturnUrl()},onError:t=>{if(t!=null&&t.Error!=null&&t.Error.Code=="RedirectUserTo"){window.location.href=t.Error.Arguments;return}if(t!=null&&t.Error!=null&&!(0,e.isEmptyOrNull)(t.Error.Message)){(0,e.notifyError)(t.Error.Message),$("#Password").focus();return}e.ErrorHandling.showServiceError(t.Error)}})}})}redirectToReturnUrl(){var n=(0,e.parseQueryString)(),r=n.returnUrl||n.ReturnUrl;if(r&&/^\//.test(r)){var o=window.location.hash;o!=null&&o!="#"&&(r+=o),window.location.href=r}else window.location.href=(0,e.resolveUrl)("~/")}getTemplate(){return`
<h2 class="text-center p-4">
    <img src="${(0,e.resolveUrl)("~/Content/site/images/serenity-logo-w-128.png")}"
        class="rounded-circle p-1" style="background-color: var(--s-sidebar-band-bg)"
        width="50" height="50" /> Serene1
</h2>

<div class="s-Panel p-4">
    <h5 class="text-center my-4">${(0,e.htmlEncode)(s.Forms.Membership.Login.LoginToYourAccount)}</h5>
    <form id="~_Form" action="">
        <div id="~_PropertyGrid"></div>
        <div class="px-field">
            <a class="float-end text-decoration-none" href="${(0,e.resolveUrl)("~/Account/ForgotPassword")}">
                ${(0,e.htmlEncode)(s.Forms.Membership.Login.ForgotPassword)}
            </a>
        </div>
        <div class="px-field">
            <button id="~_LoginButton" type="submit" class="btn btn-primary my-3 w-100">
                ${(0,e.htmlEncode)(s.Forms.Membership.Login.SignInButton)}
            </button>
        </div>
    </form>
</div>

<div class="text-center mt-2">
    <a class="text-decoration-none" href="${(0,e.resolveUrl)("~/Account/SignUp")}">${(0,e.htmlEncode)((0,e.localText)("Forms.Membership.Login.SignUpButton"))}</a>
</div>   
`}};a(l,"LoginPanel");
//# sourceMappingURL=LoginPage.js.map
