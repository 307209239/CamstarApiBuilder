// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.HistoryViewMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class HistoryViewMaintService : NamedDataObjectMaintBase
  {
    public HistoryViewMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IHistoryViewMaintService), userProfile);
    }

    public ResultStatus Delete(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) historyViewMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewMaintService) this._Channel).Delete(this._UserProfile, historyViewMaint, parameters, request, out result) : this.AddMethod((Method) new HistoryViewMaintMethod(historyViewMaint, HistoryViewMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) historyViewMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((HistoryViewMaint) null, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus Delete(HistoryViewMaint historyViewMaint)
    {
      return this.Delete(historyViewMaint, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus Delete(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.Delete(historyViewMaint, (HistoryViewMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) historyViewMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewMaintService) this._Channel).Freeze(this._UserProfile, historyViewMaint, parameters, request, out result) : this.AddMethod((Method) new HistoryViewMaintMethod(historyViewMaint, HistoryViewMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) historyViewMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((HistoryViewMaint) null, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus Freeze(HistoryViewMaint historyViewMaint)
    {
      return this.Freeze(historyViewMaint, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus Freeze(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.Freeze(historyViewMaint, (HistoryViewMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) historyViewMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewMaintService) this._Channel).GetWIPMsgs(this._UserProfile, historyViewMaint, parameters, request, out result) : this.AddMethod((Method) new HistoryViewMaintMethod(historyViewMaint, HistoryViewMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) historyViewMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((HistoryViewMaint) null, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(HistoryViewMaint historyViewMaint)
    {
      return this.GetWIPMsgs(historyViewMaint, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.GetWIPMsgs(historyViewMaint, (HistoryViewMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) historyViewMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewMaintService) this._Channel).Load(this._UserProfile, historyViewMaint, parameters, request, out result) : this.AddMethod((Method) new HistoryViewMaintMethod(historyViewMaint, HistoryViewMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) historyViewMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((HistoryViewMaint) null, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus Load(HistoryViewMaint historyViewMaint)
    {
      return this.Load(historyViewMaint, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus Load(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.Load(historyViewMaint, (HistoryViewMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_LoadESigDetails_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) historyViewMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewMaintService) this._Channel).LoadESigDetails(this._UserProfile, historyViewMaint, parameters, request, out result) : this.AddMethod((Method) new HistoryViewMaintMethod(historyViewMaint, HistoryViewMaintMethods.LoadESigDetails, (HistoryViewMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) historyViewMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((HistoryViewMaint) null, (HistoryViewMaint_LoadESigDetails_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus LoadESigDetails(HistoryViewMaint historyViewMaint)
    {
      return this.LoadESigDetails(historyViewMaint, (HistoryViewMaint_LoadESigDetails_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.LoadESigDetails(historyViewMaint, (HistoryViewMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) historyViewMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewMaintService) this._Channel).New(this._UserProfile, historyViewMaint, parameters, request, out result) : this.AddMethod((Method) new HistoryViewMaintMethod(historyViewMaint, HistoryViewMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) historyViewMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((HistoryViewMaint) null, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus New(HistoryViewMaint historyViewMaint)
    {
      return this.New(historyViewMaint, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus New(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.New(historyViewMaint, (HistoryViewMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) historyViewMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewMaintService) this._Channel).NewCopy(this._UserProfile, historyViewMaint, parameters, request, out result) : this.AddMethod((Method) new HistoryViewMaintMethod(historyViewMaint, HistoryViewMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) historyViewMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((HistoryViewMaint) null, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus NewCopy(HistoryViewMaint historyViewMaint)
    {
      return this.NewCopy(historyViewMaint, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus NewCopy(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.NewCopy(historyViewMaint, (HistoryViewMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) historyViewMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewMaintService) this._Channel).SaveAs(this._UserProfile, historyViewMaint, parameters, request, out result) : this.AddMethod((Method) new HistoryViewMaintMethod(historyViewMaint, HistoryViewMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) historyViewMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((HistoryViewMaint) null, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus SaveAs(HistoryViewMaint historyViewMaint)
    {
      return this.SaveAs(historyViewMaint, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus SaveAs(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.SaveAs(historyViewMaint, (HistoryViewMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Parameters parameters,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) historyViewMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewMaintService) this._Channel).UnFreeze(this._UserProfile, historyViewMaint, parameters, request, out result) : this.AddMethod((Method) new HistoryViewMaintMethod(historyViewMaint, HistoryViewMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) historyViewMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((HistoryViewMaint) null, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus UnFreeze(HistoryViewMaint historyViewMaint)
    {
      return this.UnFreeze(historyViewMaint, (HistoryViewMaint_Parameters) null, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus UnFreeze(
      HistoryViewMaint historyViewMaint,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.UnFreeze(historyViewMaint, (HistoryViewMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject historyViewMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewMaint_Result result1;
        ResultStatus resultStatus = this.Delete((HistoryViewMaint) historyViewMaint, (HistoryViewMaint_Parameters) parameters, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject historyViewMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((HistoryViewMaint) historyViewMaint, (HistoryViewMaint_Parameters) parameters, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject historyViewMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((HistoryViewMaint) historyViewMaint, (HistoryViewMaint_LoadESigDetails_Parameters) parameters, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject historyViewMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewMaint_Result result1;
        ResultStatus resultStatus = this.New((HistoryViewMaint) historyViewMaint, (HistoryViewMaint_Parameters) parameters, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject historyViewMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((HistoryViewMaint) historyViewMaint, (HistoryViewMaint_Parameters) parameters, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject historyViewMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((HistoryViewMaint) historyViewMaint, (HistoryViewMaint_Parameters) parameters, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject historyViewMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((HistoryViewMaint) historyViewMaint, (HistoryViewMaint_Parameters) parameters, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject historyViewMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewMaint_Result result1;
        ResultStatus resultStatus = this.Load((HistoryViewMaint) historyViewMaint, (HistoryViewMaint_Parameters) parameters, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject historyViewMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        HistoryViewMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((HistoryViewMaint) historyViewMaint, (HistoryViewMaint_Parameters) parameters, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      try
      {
        HistoryViewMaintMethod[] methods = new HistoryViewMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IHistoryViewMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        HistoryViewMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      HistoryViewMaint cdo,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      try
      {
        return ((IHistoryViewMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        HistoryViewMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((HistoryViewMaint) cdo, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.GetEnvironment((HistoryViewMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      HistoryViewMaint cdo,
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      result = (HistoryViewMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IHistoryViewMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new HistoryViewMaintMethod(cdo, HistoryViewMaintMethods.ExecuteTransaction, (HistoryViewMaint_Parameters) null));
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
        HistoryViewMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((HistoryViewMaint) cdo, (HistoryViewMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(HistoryViewMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (HistoryViewMaint_Request) null, out HistoryViewMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      HistoryViewMaint_Request request,
      out HistoryViewMaint_Result result)
    {
      return this.ExecuteTransaction((HistoryViewMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(HistoryViewMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new HistoryViewMaintMethod(cdo, HistoryViewMaintMethods.AddDataTransaction, (HistoryViewMaint_Parameters) null));
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
        return this.AddDataTransaction((HistoryViewMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
