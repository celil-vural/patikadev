import{a as U}from"../../../_chunks/chunk-3RUWMRYN.js";import{a as g}from"../../../_chunks/chunk-HV6C77RL.js";import{h as C,k as I,l as w,m as h,n as e,o as P}from"../../../_chunks/chunk-KV7X3BT7.js";import{a,b as o,c,e as y,f}from"../../../_chunks/chunk-ZR7A2VZA.js";var S=o(f(),1);var v=o(y(),1),b=o(f(),1);var R=o(y(),1),t=o(f(),1);var p=class extends R.TemplatedDialog{constructor(r){super(r);this.permissions=new U(this.byId("Permissions"),{showRevoke:!0}),h.List({UserID:this.options.userID,Module:null,Submodule:null},s=>{this.permissions.value=s.Entities}),h.ListRolePermissions({UserID:this.options.userID,Module:null,Submodule:null},s=>{this.permissions.rolePermissions=s.Entities}),this.permissions.implicitPermissions=(0,t.getRemoteData)("Administration.ImplicitPermissions"),this.dialogTitle=(0,t.format)((0,t.localText)("Site.UserPermissionDialog.DialogTitle"),this.options.username)}getDialogButtons(){return[{text:(0,t.localText)("Dialogs.OkButton"),cssClass:"btn btn-primary",click:r=>{h.Update({UserID:this.options.userID,Permissions:this.permissions.value,Module:null,Submodule:null},s=>{this.dialogClose(),window.setTimeout(()=>(0,t.notifySuccess)((0,t.localText)("Site.UserPermissionDialog.SaveSuccess")),0)})}},{text:(0,t.localText)("Dialogs.CancelButton"),click:()=>this.dialogClose()}]}getTemplate(){return'<div id="~_Permissions"></div>'}};a(p,"UserPermissionDialog");var u=o(y(),1),m=o(f(),1);var i=class extends u.EntityDialog{constructor(){super();this.form=new w(this.idPrefix);this.form.Password.change(()=>{u.EditorUtils.setRequired(this.form.PasswordConfirm,this.form.Password.value.length>0)}),this.form.Password.addValidationRule(this.uniqueName,r=>{if(this.form.Password.value.length<6)return(0,m.format)((0,m.localText)(g.Validation.MinRequiredPasswordLength),6)}),this.form.PasswordConfirm.addValidationRule(this.uniqueName,r=>{if(this.form.Password.value!=this.form.PasswordConfirm.value)return(0,m.localText)(g.Validation.PasswordConfirmMismatch)})}getFormKey(){return w.formKey}getIdProperty(){return e.idProperty}getIsActiveProperty(){return e.isActiveProperty}getLocalTextPrefix(){return e.localTextPrefix}getNameProperty(){return e.nameProperty}getService(){return P.baseUrl}getToolbarButtons(){let r=super.getToolbarButtons();return r.push({title:(0,m.localText)(g.Site.UserDialog.EditPermissionsButton),cssClass:"edit-permissions-button",icon:"fa-lock text-green",onClick:()=>{new p({userID:this.entity.UserId,username:this.entity.Username}).dialogOpen()}}),r}updateInterface(){super.updateInterface(),this.toolbar.findButton("edit-permissions-button").toggleClass("disabled",this.isNewOrDeleted())}afterLoadEntity(){super.afterLoadEntity(),this.form.Password.element.toggleClass("required",this.isNew()).closest(".field").find("sup").toggle(this.isNew()),this.form.PasswordConfirm.element.toggleClass("required",this.isNew()).closest(".field").find("sup").toggle(this.isNew())}};a(i,"UserDialog"),i=c([u.Decorators.registerClass()],i);var n=class extends v.EntityGrid{getColumnsKey(){return I.columnsKey}getDialogType(){return i}getIdProperty(){return e.idProperty}getIsActiveProperty(){return e.isActiveProperty}getLocalTextPrefix(){return e.localTextPrefix}getService(){return P.baseUrl}constructor(l){super(l)}getDefaultSortBy(){return[e.Fields.Username]}createIncludeDeletedButton(){}getColumns(){var l=super.getColumns(),r=(0,b.tryFirst)(l,d=>d.field==e.Fields.Roles);if(r){var s;C.getLookupAsync().then(d=>{s=d,this.slickGrid.invalidate()}),r.format=d=>{if(!s)return'<i class="fa fa-spinner"></i>';var x=(d.value||[]).map(T=>(s.itemById[T]||{}).RoleName||"");return x.sort(),x.join(", ")}}return l}};a(n,"UserGrid"),n=c([v.Decorators.registerClass()],n);$(function(){(0,S.initFullHeightGridPage)(new n($("#GridDiv")).element)});
//# sourceMappingURL=UserPage.js.map
