// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ProcessModelTemplateMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ProcessModelTemplateMaintService : RevisionedObjectMaintBase
  {
    public ProcessModelTemplateMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IProcessModelTemplateMaintService), userProfile);
    }

    public ResultStatus AddBusinessRule(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (AddBusinessRule), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).AddBusinessRule(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.AddBusinessRule, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddBusinessRule), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddBusinessRule()
    {
      return this.AddBusinessRule((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus AddBusinessRule(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.AddBusinessRule(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus AddBusinessRule(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.AddBusinessRule(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).Delete(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.Delete(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus Delete(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.Delete(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.DeleteAllRevisions(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.DeleteAllRevisions(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).Freeze(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.Freeze(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus Freeze(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.Freeze(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetOrganization(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetOrganization), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).GetOrganization(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.GetOrganization, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetOrganization), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetOrganization()
    {
      return this.GetOrganization((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus GetOrganization(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.GetOrganization(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus GetOrganization(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.GetOrganization(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).GetWIPMsgs(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.GetWIPMsgs(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.GetWIPMsgs(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).Load(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus Load(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.Load(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus Load(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.Load(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadBusinessRules(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadBusinessRules), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).LoadBusinessRules(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.LoadBusinessRules, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadBusinessRules), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadBusinessRules()
    {
      return this.LoadBusinessRules((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.LoadBusinessRules(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus LoadBusinessRules(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.LoadBusinessRules(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_LoadESigDetails_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).LoadESigDetails(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.LoadESigDetails, (ProcessModelTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_LoadESigDetails_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.LoadESigDetails(processModelTemplateMaint, (ProcessModelTemplateMaint_LoadESigDetails_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.LoadESigDetails(processModelTemplateMaint, (ProcessModelTemplateMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).New(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus New(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.New(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus New(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.New(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).NewCopy(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.NewCopy(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus NewCopy(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.NewCopy(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).NewRev(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus NewRev(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.NewRev(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus NewRev(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.NewRev(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).NewRevCopy(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.NewRevCopy(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.NewRevCopy(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).SaveAs(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.SaveAs(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus SaveAs(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.SaveAs(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).SaveAsRev(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.SaveAsRev(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.SaveAsRev(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).UnFreeze(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.UnFreeze(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.UnFreeze(processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) null, request, out result);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_ValidateEmployeeRoleCombination_Parameters parameters,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ValidateEmployeeRoleCombination), (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).ValidateEmployeeRoleCombination(this._UserProfile, processModelTemplateMaint, parameters, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(processModelTemplateMaint, ProcessModelTemplateMaintMethods.ValidateEmployeeRoleCombination, (ProcessModelTemplateMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateEmployeeRoleCombination), res, (DCObject) processModelTemplateMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateEmployeeRoleCombination()
    {
      return this.ValidateEmployeeRoleCombination((ProcessModelTemplateMaint) null, (ProcessModelTemplateMaint_ValidateEmployeeRoleCombination_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      ProcessModelTemplateMaint processModelTemplateMaint)
    {
      return this.ValidateEmployeeRoleCombination(processModelTemplateMaint, (ProcessModelTemplateMaint_ValidateEmployeeRoleCombination_Parameters) null, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus ValidateEmployeeRoleCombination(
      ProcessModelTemplateMaint processModelTemplateMaint,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.ValidateEmployeeRoleCombination(processModelTemplateMaint, (ProcessModelTemplateMaint_ValidateEmployeeRoleCombination_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_LoadESigDetails_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.New((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.Load((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject processModelTemplateMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ProcessModelTemplateMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ProcessModelTemplateMaint) processModelTemplateMaint, (ProcessModelTemplateMaint_Parameters) parameters, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      try
      {
        ProcessModelTemplateMaintMethod[] methods = new ProcessModelTemplateMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IProcessModelTemplateMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessModelTemplateMaint cdo,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      try
      {
        return ((IProcessModelTemplateMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ProcessModelTemplateMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ProcessModelTemplateMaint) cdo, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.GetEnvironment((ProcessModelTemplateMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ProcessModelTemplateMaint cdo,
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      result = (ProcessModelTemplateMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IProcessModelTemplateMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(cdo, ProcessModelTemplateMaintMethods.ExecuteTransaction, (ProcessModelTemplateMaint_Parameters) null));
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
        ProcessModelTemplateMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ProcessModelTemplateMaint) cdo, (ProcessModelTemplateMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ProcessModelTemplateMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ProcessModelTemplateMaint_Request) null, out ProcessModelTemplateMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ProcessModelTemplateMaint_Request request,
      out ProcessModelTemplateMaint_Result result)
    {
      return this.ExecuteTransaction((ProcessModelTemplateMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ProcessModelTemplateMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ProcessModelTemplateMaintMethod(cdo, ProcessModelTemplateMaintMethods.AddDataTransaction, (ProcessModelTemplateMaint_Parameters) null));
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
        return this.AddDataTransaction((ProcessModelTemplateMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
