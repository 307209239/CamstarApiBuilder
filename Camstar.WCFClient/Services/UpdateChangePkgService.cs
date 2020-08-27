// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UpdateChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UpdateChangePkgService : ChangeMgtTxnBase
  {
    public UpdateChangePkgService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUpdateChangePkgService), userProfile);
    }

    public ResultStatus CreateParametricData(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).CreateParametricData(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(UpdateChangePkg updateChangePkg)
    {
      return this.CreateParametricData(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.CreateParametricData(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus CreateSheet(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (CreateSheet), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).CreateSheet(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.CreateSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateSheet), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateSheet()
    {
      return this.CreateSheet((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus CreateSheet(UpdateChangePkg updateChangePkg)
    {
      return this.CreateSheet(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus CreateSheet(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.CreateSheet(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).GetActions(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus GetActions(UpdateChangePkg updateChangePkg)
    {
      return this.GetActions(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus GetActions(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.GetActions(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetDetails(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetDetails), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).GetApprovalSheetDetails(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.GetApprovalSheetDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetDetails), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetDetails()
    {
      return this.GetApprovalSheetDetails((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(UpdateChangePkg updateChangePkg)
    {
      return this.GetApprovalSheetDetails(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus GetApprovalSheetDetails(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.GetApprovalSheetDetails(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(UpdateChangePkg updateChangePkg)
    {
      return this.GetApprovalSheetTemplate(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.GetApprovalSheetTemplate(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).GetDataPoints(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(UpdateChangePkg updateChangePkg)
    {
      return this.GetDataPoints(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.GetDataPoints(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).GetWIPMsgs(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(UpdateChangePkg updateChangePkg)
    {
      return this.GetWIPMsgs(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.GetWIPMsgs(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).Load(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus Load(UpdateChangePkg updateChangePkg)
    {
      return this.Load(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus Load(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.Load(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus LoadCollaboratorTemplate(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (LoadCollaboratorTemplate), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).LoadCollaboratorTemplate(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.LoadCollaboratorTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadCollaboratorTemplate), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadCollaboratorTemplate()
    {
      return this.LoadCollaboratorTemplate((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus LoadCollaboratorTemplate(UpdateChangePkg updateChangePkg)
    {
      return this.LoadCollaboratorTemplate(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus LoadCollaboratorTemplate(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.LoadCollaboratorTemplate(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus LoadDefaultMessages(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (LoadDefaultMessages), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).LoadDefaultMessages(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.LoadDefaultMessages, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadDefaultMessages), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadDefaultMessages()
    {
      return this.LoadDefaultMessages((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus LoadDefaultMessages(UpdateChangePkg updateChangePkg)
    {
      return this.LoadDefaultMessages(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus LoadDefaultMessages(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.LoadDefaultMessages(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_LoadESigDetails_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).LoadESigDetails(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.LoadESigDetails, (UpdateChangePkg_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UpdateChangePkg) null, (UpdateChangePkg_LoadESigDetails_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(UpdateChangePkg updateChangePkg)
    {
      return this.LoadESigDetails(updateChangePkg, (UpdateChangePkg_LoadESigDetails_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.LoadESigDetails(updateChangePkg, (UpdateChangePkg_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).ProcessComputation(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(UpdateChangePkg updateChangePkg)
    {
      return this.ProcessComputation(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.ProcessComputation(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).ResolveParametricData(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(UpdateChangePkg updateChangePkg)
    {
      return this.ResolveParametricData(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.ResolveParametricData(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus SaveApprovalSheet(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (SaveApprovalSheet), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).SaveApprovalSheet(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.SaveApprovalSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveApprovalSheet), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveApprovalSheet()
    {
      return this.SaveApprovalSheet((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus SaveApprovalSheet(UpdateChangePkg updateChangePkg)
    {
      return this.SaveApprovalSheet(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus SaveApprovalSheet(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.SaveApprovalSheet(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus SaveCollaboratorDetails(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (SaveCollaboratorDetails), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).SaveCollaboratorDetails(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.SaveCollaboratorDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveCollaboratorDetails), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveCollaboratorDetails()
    {
      return this.SaveCollaboratorDetails((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus SaveCollaboratorDetails(UpdateChangePkg updateChangePkg)
    {
      return this.SaveCollaboratorDetails(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus SaveCollaboratorDetails(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.SaveCollaboratorDetails(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus SendEmailToCollaborators(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Parameters parameters,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (SendEmailToCollaborators), (DCObject) updateChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).SendEmailToCollaborators(this._UserProfile, updateChangePkg, parameters, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(updateChangePkg, UpdateChangePkgMethods.SendEmailToCollaborators, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SendEmailToCollaborators), res, (DCObject) updateChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SendEmailToCollaborators()
    {
      return this.SendEmailToCollaborators((UpdateChangePkg) null, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus SendEmailToCollaborators(UpdateChangePkg updateChangePkg)
    {
      return this.SendEmailToCollaborators(updateChangePkg, (UpdateChangePkg_Parameters) null, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus SendEmailToCollaborators(
      UpdateChangePkg updateChangePkg,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.SendEmailToCollaborators(updateChangePkg, (UpdateChangePkg_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject updateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus parametricData = this.CreateParametricData((UpdateChangePkg) updateChangePkg, (UpdateChangePkg_Parameters) parameters, (UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject updateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus actions = this.GetActions((UpdateChangePkg) updateChangePkg, (UpdateChangePkg_Parameters) parameters, (UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject updateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((UpdateChangePkg) updateChangePkg, (UpdateChangePkg_Parameters) parameters, (UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject updateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UpdateChangePkg) updateChangePkg, (UpdateChangePkg_LoadESigDetails_Parameters) parameters, (UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject updateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((UpdateChangePkg) updateChangePkg, (UpdateChangePkg_Parameters) parameters, (UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject updateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((UpdateChangePkg) updateChangePkg, (UpdateChangePkg_Parameters) parameters, (UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject updateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus resultStatus = this.Load((UpdateChangePkg) updateChangePkg, (UpdateChangePkg_Parameters) parameters, (UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject updateChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UpdateChangePkg) updateChangePkg, (UpdateChangePkg_Parameters) parameters, (UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      try
      {
        UpdateChangePkgMethod[] methods = new UpdateChangePkgMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUpdateChangePkgService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateChangePkg cdo,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      try
      {
        return ((IUpdateChangePkgService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus environment = this.GetEnvironment((UpdateChangePkg) cdo, (UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.GetEnvironment((UpdateChangePkg) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UpdateChangePkg cdo,
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      result = (UpdateChangePkg_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUpdateChangePkgService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UpdateChangePkgMethod(cdo, UpdateChangePkgMethods.ExecuteTransaction, (UpdateChangePkg_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UpdateChangePkg_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UpdateChangePkg) cdo, (UpdateChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UpdateChangePkg cdo)
    {
      return this.ExecuteTransaction(cdo, (UpdateChangePkg_Request) null, out UpdateChangePkg_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UpdateChangePkg_Request request,
      out UpdateChangePkg_Result result)
    {
      return this.ExecuteTransaction((UpdateChangePkg) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UpdateChangePkg cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UpdateChangePkgMethod(cdo, UpdateChangePkgMethods.AddDataTransaction, (UpdateChangePkg_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((UpdateChangePkg) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
