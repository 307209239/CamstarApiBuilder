// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IssueReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class IssueReasonMaintService : UserCodeMaintBase
  {
    public IssueReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IIssueReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueReasonMaintService) this._Channel).Delete(this._UserProfile, issueReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueReasonMaintMethod(issueReasonMaint, IssueReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((IssueReasonMaint) null, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus Delete(IssueReasonMaint issueReasonMaint)
    {
      return this.Delete(issueReasonMaint, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus Delete(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.Delete(issueReasonMaint, (IssueReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueReasonMaintService) this._Channel).Freeze(this._UserProfile, issueReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueReasonMaintMethod(issueReasonMaint, IssueReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((IssueReasonMaint) null, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus Freeze(IssueReasonMaint issueReasonMaint)
    {
      return this.Freeze(issueReasonMaint, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.Freeze(issueReasonMaint, (IssueReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, issueReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueReasonMaintMethod(issueReasonMaint, IssueReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((IssueReasonMaint) null, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(IssueReasonMaint issueReasonMaint)
    {
      return this.GetWIPMsgs(issueReasonMaint, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.GetWIPMsgs(issueReasonMaint, (IssueReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueReasonMaintService) this._Channel).Load(this._UserProfile, issueReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueReasonMaintMethod(issueReasonMaint, IssueReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((IssueReasonMaint) null, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus Load(IssueReasonMaint issueReasonMaint)
    {
      return this.Load(issueReasonMaint, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus Load(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.Load(issueReasonMaint, (IssueReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_LoadESigDetails_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, issueReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueReasonMaintMethod(issueReasonMaint, IssueReasonMaintMethods.LoadESigDetails, (IssueReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((IssueReasonMaint) null, (IssueReasonMaint_LoadESigDetails_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(IssueReasonMaint issueReasonMaint)
    {
      return this.LoadESigDetails(issueReasonMaint, (IssueReasonMaint_LoadESigDetails_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.LoadESigDetails(issueReasonMaint, (IssueReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueReasonMaintService) this._Channel).New(this._UserProfile, issueReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueReasonMaintMethod(issueReasonMaint, IssueReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((IssueReasonMaint) null, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus New(IssueReasonMaint issueReasonMaint)
    {
      return this.New(issueReasonMaint, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus New(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.New(issueReasonMaint, (IssueReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueReasonMaintService) this._Channel).NewCopy(this._UserProfile, issueReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueReasonMaintMethod(issueReasonMaint, IssueReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((IssueReasonMaint) null, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus NewCopy(IssueReasonMaint issueReasonMaint)
    {
      return this.NewCopy(issueReasonMaint, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.NewCopy(issueReasonMaint, (IssueReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueReasonMaintService) this._Channel).SaveAs(this._UserProfile, issueReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueReasonMaintMethod(issueReasonMaint, IssueReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((IssueReasonMaint) null, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus SaveAs(IssueReasonMaint issueReasonMaint)
    {
      return this.SaveAs(issueReasonMaint, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.SaveAs(issueReasonMaint, (IssueReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Parameters parameters,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueReasonMaintService) this._Channel).UnFreeze(this._UserProfile, issueReasonMaint, parameters, request, out result) : this.AddMethod((Method) new IssueReasonMaintMethod(issueReasonMaint, IssueReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) issueReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((IssueReasonMaint) null, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(IssueReasonMaint issueReasonMaint)
    {
      return this.UnFreeze(issueReasonMaint, (IssueReasonMaint_Parameters) null, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      IssueReasonMaint issueReasonMaint,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.UnFreeze(issueReasonMaint, (IssueReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject issueReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((IssueReasonMaint) issueReasonMaint, (IssueReasonMaint_Parameters) parameters, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject issueReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((IssueReasonMaint) issueReasonMaint, (IssueReasonMaint_Parameters) parameters, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject issueReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((IssueReasonMaint) issueReasonMaint, (IssueReasonMaint_LoadESigDetails_Parameters) parameters, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject issueReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((IssueReasonMaint) issueReasonMaint, (IssueReasonMaint_Parameters) parameters, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject issueReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((IssueReasonMaint) issueReasonMaint, (IssueReasonMaint_Parameters) parameters, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject issueReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((IssueReasonMaint) issueReasonMaint, (IssueReasonMaint_Parameters) parameters, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject issueReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((IssueReasonMaint) issueReasonMaint, (IssueReasonMaint_Parameters) parameters, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject issueReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((IssueReasonMaint) issueReasonMaint, (IssueReasonMaint_Parameters) parameters, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject issueReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        IssueReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((IssueReasonMaint) issueReasonMaint, (IssueReasonMaint_Parameters) parameters, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      try
      {
        IssueReasonMaintMethod[] methods = new IssueReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IIssueReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        IssueReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      IssueReasonMaint cdo,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      try
      {
        return ((IIssueReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        IssueReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((IssueReasonMaint) cdo, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.GetEnvironment((IssueReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      IssueReasonMaint cdo,
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      result = (IssueReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IIssueReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new IssueReasonMaintMethod(cdo, IssueReasonMaintMethods.ExecuteTransaction, (IssueReasonMaint_Parameters) null));
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
        IssueReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((IssueReasonMaint) cdo, (IssueReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(IssueReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (IssueReasonMaint_Request) null, out IssueReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      IssueReasonMaint_Request request,
      out IssueReasonMaint_Result result)
    {
      return this.ExecuteTransaction((IssueReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(IssueReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new IssueReasonMaintMethod(cdo, IssueReasonMaintMethods.AddDataTransaction, (IssueReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((IssueReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
