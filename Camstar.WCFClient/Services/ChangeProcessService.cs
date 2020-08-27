// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeProcessService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeProcessService : ProcessObjectTxnBase
  {
    public ChangeProcessService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeProcessService), userProfile);
    }

    public ResultStatus AddBusinessRule(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (AddBusinessRule), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).AddBusinessRule(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.AddBusinessRule, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddBusinessRule), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddBusinessRule()
    {
      return this.AddBusinessRule((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus AddBusinessRule(ChangeProcess changeProcess)
    {
      return this.AddBusinessRule(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus AddBusinessRule(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.AddBusinessRule(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus CreateParametricData(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).CreateParametricData(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus CreateParametricData(ChangeProcess changeProcess)
    {
      return this.CreateParametricData(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus CreateParametricData(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.CreateParametricData(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).Delete(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus Delete(ChangeProcess changeProcess)
    {
      return this.Delete(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus Delete(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.Delete(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).GetActions(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetActions(ChangeProcess changeProcess)
    {
      return this.GetActions(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetActions(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.GetActions(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(ChangeProcess changeProcess)
    {
      return this.GetApprovalSheetTemplate(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.GetApprovalSheetTemplate(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus GetChecklistEntries(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (GetChecklistEntries), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).GetChecklistEntries(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.GetChecklistEntries, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetChecklistEntries), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetChecklistEntries()
    {
      return this.GetChecklistEntries((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetChecklistEntries(ChangeProcess changeProcess)
    {
      return this.GetChecklistEntries(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetChecklistEntries(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.GetChecklistEntries(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).GetDataPoints(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetDataPoints(ChangeProcess changeProcess)
    {
      return this.GetDataPoints(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetDataPoints(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.GetDataPoints(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus GetOrganization(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (GetOrganization), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).GetOrganization(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.GetOrganization, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetOrganization), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetOrganization()
    {
      return this.GetOrganization((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetOrganization(ChangeProcess changeProcess)
    {
      return this.GetOrganization(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetOrganization(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.GetOrganization(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus GetPrerequisites(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (GetPrerequisites), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).GetPrerequisites(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.GetPrerequisites, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetPrerequisites), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetPrerequisites()
    {
      return this.GetPrerequisites((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetPrerequisites(ChangeProcess changeProcess)
    {
      return this.GetPrerequisites(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetPrerequisites(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.GetPrerequisites(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).GetWIPMsgs(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeProcess changeProcess)
    {
      return this.GetWIPMsgs(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.GetWIPMsgs(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).Load(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus Load(ChangeProcess changeProcess)
    {
      return this.Load(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus Load(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.Load(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).LoadBusinessRules(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus LoadBusinessRules(ChangeProcess changeProcess)
    {
      return this.LoadBusinessRules(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.LoadBusinessRules(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).LoadChecklistTemplate(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus LoadChecklistTemplate(ChangeProcess changeProcess)
    {
      return this.LoadChecklistTemplate(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.LoadChecklistTemplate(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus LoadDataPoints(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (LoadDataPoints), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).LoadDataPoints(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.LoadDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadDataPoints), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadDataPoints()
    {
      return this.LoadDataPoints((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus LoadDataPoints(ChangeProcess changeProcess)
    {
      return this.LoadDataPoints(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus LoadDataPoints(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.LoadDataPoints(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).LoadESigDetails(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeProcess changeProcess)
    {
      return this.LoadESigDetails(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.LoadESigDetails(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).New(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus New(ChangeProcess changeProcess)
    {
      return this.New(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus New(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.New(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).PreviewChecklist(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus PreviewChecklist(ChangeProcess changeProcess)
    {
      return this.PreviewChecklist(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus PreviewChecklist(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.PreviewChecklist(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).ProcessComputation(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus ProcessComputation(ChangeProcess changeProcess)
    {
      return this.ProcessComputation(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus ProcessComputation(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.ProcessComputation(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).ResolveParametricData(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus ResolveParametricData(ChangeProcess changeProcess)
    {
      return this.ResolveParametricData(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus ResolveParametricData(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.ResolveParametricData(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus ReviewDataPoints(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (ReviewDataPoints), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).ReviewDataPoints(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.ReviewDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ReviewDataPoints), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ReviewDataPoints()
    {
      return this.ReviewDataPoints((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus ReviewDataPoints(ChangeProcess changeProcess)
    {
      return this.ReviewDataPoints(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus ReviewDataPoints(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.ReviewDataPoints(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus SetTriageComplete(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (SetTriageComplete), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).SetTriageComplete(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.SetTriageComplete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetTriageComplete), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetTriageComplete()
    {
      return this.SetTriageComplete((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus SetTriageComplete(ChangeProcess changeProcess)
    {
      return this.SetTriageComplete(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus SetTriageComplete(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.SetTriageComplete(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    public ResultStatus ValidateProcessObject(
      ChangeProcess changeProcess,
      ChangeProcess_Parameters parameters,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (ValidateProcessObject), (DCObject) changeProcess, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).ValidateProcessObject(this._UserProfile, changeProcess, parameters, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(changeProcess, ChangeProcessMethods.ValidateProcessObject, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateProcessObject), res, (DCObject) changeProcess, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateProcessObject()
    {
      return this.ValidateProcessObject((ChangeProcess) null, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus ValidateProcessObject(ChangeProcess changeProcess)
    {
      return this.ValidateProcessObject(changeProcess, (ChangeProcess_Parameters) null, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus ValidateProcessObject(
      ChangeProcess changeProcess,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.ValidateProcessObject(changeProcess, (ChangeProcess_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeProcess_Result result1;
        ResultStatus parametricData = this.CreateParametricData((ChangeProcess) changeProcess, (ChangeProcess_Parameters) parameters, (ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeProcess_Result result1;
        ResultStatus actions = this.GetActions((ChangeProcess) changeProcess, (ChangeProcess_Parameters) parameters, (ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeProcess_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((ChangeProcess) changeProcess, (ChangeProcess_Parameters) parameters, (ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeProcess_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeProcess) changeProcess, (ChangeProcess_Parameters) parameters, (ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeProcess_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((ChangeProcess) changeProcess, (ChangeProcess_Parameters) parameters, (ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeProcess_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((ChangeProcess) changeProcess, (ChangeProcess_Parameters) parameters, (ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeProcess_Result result1;
        ResultStatus resultStatus = this.Load((ChangeProcess) changeProcess, (ChangeProcess_Parameters) parameters, (ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeProcess,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeProcess_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeProcess) changeProcess, (ChangeProcess_Parameters) parameters, (ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      try
      {
        ChangeProcessMethod[] methods = new ChangeProcessMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeProcessService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeProcess_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeProcess cdo,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      try
      {
        return ((IChangeProcessService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeProcess_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeProcess) cdo, (ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.GetEnvironment((ChangeProcess) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeProcess cdo,
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      result = (ChangeProcess_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeProcessService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeProcessMethod(cdo, ChangeProcessMethods.ExecuteTransaction, (ChangeProcess_Parameters) null));
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
        ChangeProcess_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeProcess) cdo, (ChangeProcess_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeProcess cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeProcess_Request) null, out ChangeProcess_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeProcess_Request request,
      out ChangeProcess_Result result)
    {
      return this.ExecuteTransaction((ChangeProcess) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeProcess cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeProcessMethod(cdo, ChangeProcessMethods.AddDataTransaction, (ChangeProcess_Parameters) null));
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
        return this.AddDataTransaction((ChangeProcess) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
