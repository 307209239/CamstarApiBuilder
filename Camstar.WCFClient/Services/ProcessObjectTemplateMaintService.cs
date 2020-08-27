// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessObjectTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProcessObjectTemplateMaintService : NamedDataObjectMaintBase
  {
    public ProcessObjectTemplateMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProcessObjectTemplateMaintService), userProfile);
    }

    public ResultStatus AddBusinessRule(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (AddBusinessRule), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).AddBusinessRule(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.AddBusinessRule, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddBusinessRule), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddBusinessRule()
    {
      return this.AddBusinessRule((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus AddBusinessRule(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.AddBusinessRule(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus AddBusinessRule(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.AddBusinessRule(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus CheckChecklist(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (CheckChecklist), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).CheckChecklist(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.CheckChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CheckChecklist), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CheckChecklist()
    {
      return this.CheckChecklist((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus CheckChecklist(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.CheckChecklist(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus CheckChecklist(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.CheckChecklist(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).Delete(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.Delete(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.Delete(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).Freeze(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.Freeze(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.Freeze(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetApprovalSheetTemplate), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).GetApprovalSheetTemplate(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.GetApprovalSheetTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetApprovalSheetTemplate), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetApprovalSheetTemplate()
    {
      return this.GetApprovalSheetTemplate((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.GetApprovalSheetTemplate(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus GetApprovalSheetTemplate(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.GetApprovalSheetTemplate(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetOrganization(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetOrganization), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).GetOrganization(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.GetOrganization, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetOrganization), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetOrganization()
    {
      return this.GetOrganization((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus GetOrganization(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.GetOrganization(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus GetOrganization(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.GetOrganization(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).GetWIPMsgs(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.GetWIPMsgs(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.GetWIPMsgs(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).Load(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus Load(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.Load(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus Load(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.Load(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).LoadBusinessRules(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.LoadBusinessRules(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.LoadBusinessRules(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).LoadChecklistTemplate(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.LoadChecklistTemplate(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.LoadChecklistTemplate(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_LoadESigDetails_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).LoadESigDetails(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.LoadESigDetails, (ProcessObjectTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_LoadESigDetails_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.LoadESigDetails(processObjectTemplateMaint, (ProcessObjectTemplateMaint_LoadESigDetails_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.LoadESigDetails(processObjectTemplateMaint, (ProcessObjectTemplateMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).New(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus New(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.New(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus New(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.New(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).NewCopy(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.NewCopy(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.NewCopy(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus PostLoad_Sheet(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (PostLoad_Sheet), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).PostLoad_Sheet(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.PostLoad_Sheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PostLoad_Sheet), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PostLoad_Sheet()
    {
      return this.PostLoad_Sheet((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus PostLoad_Sheet(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.PostLoad_Sheet(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus PostLoad_Sheet(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.PostLoad_Sheet(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus PreviewChecklist(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (PreviewChecklist), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).PreviewChecklist(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.PreviewChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PreviewChecklist), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PreviewChecklist()
    {
      return this.PreviewChecklist((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.PreviewChecklist(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus PreviewChecklist(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.PreviewChecklist(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus RefreshApprovalSheet(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (RefreshApprovalSheet), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).RefreshApprovalSheet(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.RefreshApprovalSheet, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (RefreshApprovalSheet), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus RefreshApprovalSheet()
    {
      return this.RefreshApprovalSheet((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus RefreshApprovalSheet(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.RefreshApprovalSheet(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus RefreshApprovalSheet(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.RefreshApprovalSheet(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).SaveAs(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.SaveAs(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.SaveAs(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).UnFreeze(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.UnFreeze(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.UnFreeze(processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_ValidateEmployeeRoleCombination_Parameters parameters,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateEmployeeRoleCombination), (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).ValidateEmployeeRoleCombination(this._UserProfile, processObjectTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(processObjectTemplateMaint, ProcessObjectTemplateMaintMethods.ValidateEmployeeRoleCombination, (ProcessObjectTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateEmployeeRoleCombination), res, (DCObject) processObjectTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateEmployeeRoleCombination()
    {
      return this.ValidateEmployeeRoleCombination((ProcessObjectTemplateMaint) null, (ProcessObjectTemplateMaint_ValidateEmployeeRoleCombination_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      ProcessObjectTemplateMaint processObjectTemplateMaint)
    {
      return this.ValidateEmployeeRoleCombination(processObjectTemplateMaint, (ProcessObjectTemplateMaint_ValidateEmployeeRoleCombination_Parameters) null, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      ProcessObjectTemplateMaint processObjectTemplateMaint,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.ValidateEmployeeRoleCombination(processObjectTemplateMaint, (ProcessObjectTemplateMaint_ValidateEmployeeRoleCombination_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProcessObjectTemplateMaint) processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) parameters, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProcessObjectTemplateMaint) processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) parameters, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProcessObjectTemplateMaint) processObjectTemplateMaint, (ProcessObjectTemplateMaint_LoadESigDetails_Parameters) parameters, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus resultStatus = this.New((ProcessObjectTemplateMaint) processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) parameters, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProcessObjectTemplateMaint) processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) parameters, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProcessObjectTemplateMaint) processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) parameters, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProcessObjectTemplateMaint) processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) parameters, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProcessObjectTemplateMaint) processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) parameters, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject processObjectTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProcessObjectTemplateMaint) processObjectTemplateMaint, (ProcessObjectTemplateMaint_Parameters) parameters, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      try
      {
        ProcessObjectTemplateMaintMethod[] methods = new ProcessObjectTemplateMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProcessObjectTemplateMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessObjectTemplateMaint cdo,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      try
      {
        return ((IProcessObjectTemplateMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProcessObjectTemplateMaint) cdo, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.GetEnvironment((ProcessObjectTemplateMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProcessObjectTemplateMaint cdo,
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      result = (ProcessObjectTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessObjectTemplateMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(cdo, ProcessObjectTemplateMaintMethods.ExecuteTransaction, (ProcessObjectTemplateMaint_Parameters) null));
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
        ProcessObjectTemplateMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProcessObjectTemplateMaint) cdo, (ProcessObjectTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProcessObjectTemplateMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProcessObjectTemplateMaint_Request) null, out ProcessObjectTemplateMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProcessObjectTemplateMaint_Request request,
      out ProcessObjectTemplateMaint_Result result)
    {
      return this.ExecuteTransaction((ProcessObjectTemplateMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProcessObjectTemplateMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProcessObjectTemplateMaintMethod(cdo, ProcessObjectTemplateMaintMethods.AddDataTransaction, (ProcessObjectTemplateMaint_Parameters) null));
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
        return this.AddDataTransaction((ProcessObjectTemplateMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
