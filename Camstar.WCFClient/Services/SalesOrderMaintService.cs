// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SalesOrderMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SalesOrderMaintService : NamedDataObjectMaintBase
  {
    public SalesOrderMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISalesOrderMaintService), userProfile);
    }

    public ResultStatus Delete(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISalesOrderMaintService) this._Channel).Delete(this._UserProfile, salesOrderMaint, parameters, request, out result) : this.AddMethod((Method) new SalesOrderMaintMethod(salesOrderMaint, SalesOrderMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SalesOrderMaint) null, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus Delete(SalesOrderMaint salesOrderMaint)
    {
      return this.Delete(salesOrderMaint, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus Delete(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.Delete(salesOrderMaint, (SalesOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISalesOrderMaintService) this._Channel).Freeze(this._UserProfile, salesOrderMaint, parameters, request, out result) : this.AddMethod((Method) new SalesOrderMaintMethod(salesOrderMaint, SalesOrderMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SalesOrderMaint) null, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus Freeze(SalesOrderMaint salesOrderMaint)
    {
      return this.Freeze(salesOrderMaint, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus Freeze(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.Freeze(salesOrderMaint, (SalesOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISalesOrderMaintService) this._Channel).GetWIPMsgs(this._UserProfile, salesOrderMaint, parameters, request, out result) : this.AddMethod((Method) new SalesOrderMaintMethod(salesOrderMaint, SalesOrderMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SalesOrderMaint) null, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SalesOrderMaint salesOrderMaint)
    {
      return this.GetWIPMsgs(salesOrderMaint, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.GetWIPMsgs(salesOrderMaint, (SalesOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISalesOrderMaintService) this._Channel).Load(this._UserProfile, salesOrderMaint, parameters, request, out result) : this.AddMethod((Method) new SalesOrderMaintMethod(salesOrderMaint, SalesOrderMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SalesOrderMaint) null, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus Load(SalesOrderMaint salesOrderMaint)
    {
      return this.Load(salesOrderMaint, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus Load(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.Load(salesOrderMaint, (SalesOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_LoadESigDetails_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISalesOrderMaintService) this._Channel).LoadESigDetails(this._UserProfile, salesOrderMaint, parameters, request, out result) : this.AddMethod((Method) new SalesOrderMaintMethod(salesOrderMaint, SalesOrderMaintMethods.LoadESigDetails, (SalesOrderMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SalesOrderMaint) null, (SalesOrderMaint_LoadESigDetails_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SalesOrderMaint salesOrderMaint)
    {
      return this.LoadESigDetails(salesOrderMaint, (SalesOrderMaint_LoadESigDetails_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.LoadESigDetails(salesOrderMaint, (SalesOrderMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISalesOrderMaintService) this._Channel).New(this._UserProfile, salesOrderMaint, parameters, request, out result) : this.AddMethod((Method) new SalesOrderMaintMethod(salesOrderMaint, SalesOrderMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SalesOrderMaint) null, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus New(SalesOrderMaint salesOrderMaint)
    {
      return this.New(salesOrderMaint, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus New(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.New(salesOrderMaint, (SalesOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISalesOrderMaintService) this._Channel).NewCopy(this._UserProfile, salesOrderMaint, parameters, request, out result) : this.AddMethod((Method) new SalesOrderMaintMethod(salesOrderMaint, SalesOrderMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SalesOrderMaint) null, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus NewCopy(SalesOrderMaint salesOrderMaint)
    {
      return this.NewCopy(salesOrderMaint, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus NewCopy(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.NewCopy(salesOrderMaint, (SalesOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISalesOrderMaintService) this._Channel).SaveAs(this._UserProfile, salesOrderMaint, parameters, request, out result) : this.AddMethod((Method) new SalesOrderMaintMethod(salesOrderMaint, SalesOrderMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SalesOrderMaint) null, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus SaveAs(SalesOrderMaint salesOrderMaint)
    {
      return this.SaveAs(salesOrderMaint, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus SaveAs(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.SaveAs(salesOrderMaint, (SalesOrderMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Parameters parameters,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISalesOrderMaintService) this._Channel).UnFreeze(this._UserProfile, salesOrderMaint, parameters, request, out result) : this.AddMethod((Method) new SalesOrderMaintMethod(salesOrderMaint, SalesOrderMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) salesOrderMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SalesOrderMaint) null, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus UnFreeze(SalesOrderMaint salesOrderMaint)
    {
      return this.UnFreeze(salesOrderMaint, (SalesOrderMaint_Parameters) null, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SalesOrderMaint salesOrderMaint,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.UnFreeze(salesOrderMaint, (SalesOrderMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject salesOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SalesOrderMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SalesOrderMaint) salesOrderMaint, (SalesOrderMaint_Parameters) parameters, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject salesOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SalesOrderMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SalesOrderMaint) salesOrderMaint, (SalesOrderMaint_Parameters) parameters, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject salesOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SalesOrderMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SalesOrderMaint) salesOrderMaint, (SalesOrderMaint_LoadESigDetails_Parameters) parameters, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject salesOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SalesOrderMaint_Result result1;
        ResultStatus resultStatus = this.New((SalesOrderMaint) salesOrderMaint, (SalesOrderMaint_Parameters) parameters, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject salesOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SalesOrderMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SalesOrderMaint) salesOrderMaint, (SalesOrderMaint_Parameters) parameters, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject salesOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SalesOrderMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SalesOrderMaint) salesOrderMaint, (SalesOrderMaint_Parameters) parameters, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject salesOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SalesOrderMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SalesOrderMaint) salesOrderMaint, (SalesOrderMaint_Parameters) parameters, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject salesOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SalesOrderMaint_Result result1;
        ResultStatus resultStatus = this.Load((SalesOrderMaint) salesOrderMaint, (SalesOrderMaint_Parameters) parameters, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject salesOrderMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SalesOrderMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SalesOrderMaint) salesOrderMaint, (SalesOrderMaint_Parameters) parameters, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      try
      {
        SalesOrderMaintMethod[] methods = new SalesOrderMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISalesOrderMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SalesOrderMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SalesOrderMaint cdo,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      try
      {
        return ((ISalesOrderMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SalesOrderMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SalesOrderMaint) cdo, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.GetEnvironment((SalesOrderMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SalesOrderMaint cdo,
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      result = (SalesOrderMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISalesOrderMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SalesOrderMaintMethod(cdo, SalesOrderMaintMethods.ExecuteTransaction, (SalesOrderMaint_Parameters) null));
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
        SalesOrderMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SalesOrderMaint) cdo, (SalesOrderMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SalesOrderMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SalesOrderMaint_Request) null, out SalesOrderMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SalesOrderMaint_Request request,
      out SalesOrderMaint_Result result)
    {
      return this.ExecuteTransaction((SalesOrderMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SalesOrderMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SalesOrderMaintMethod(cdo, SalesOrderMaintMethods.AddDataTransaction, (SalesOrderMaint_Parameters) null));
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
        return this.AddDataTransaction((SalesOrderMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
