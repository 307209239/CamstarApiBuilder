// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BuyReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BuyReasonMaintService : UserCodeMaintBase
  {
    public BuyReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBuyReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonMaintService) this._Channel).Delete(this._UserProfile, buyReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonMaintMethod(buyReasonMaint, BuyReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BuyReasonMaint) null, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus Delete(BuyReasonMaint buyReasonMaint)
    {
      return this.Delete(buyReasonMaint, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus Delete(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.Delete(buyReasonMaint, (BuyReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonMaintService) this._Channel).Freeze(this._UserProfile, buyReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonMaintMethod(buyReasonMaint, BuyReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BuyReasonMaint) null, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus Freeze(BuyReasonMaint buyReasonMaint)
    {
      return this.Freeze(buyReasonMaint, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.Freeze(buyReasonMaint, (BuyReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, buyReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonMaintMethod(buyReasonMaint, BuyReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BuyReasonMaint) null, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BuyReasonMaint buyReasonMaint)
    {
      return this.GetWIPMsgs(buyReasonMaint, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.GetWIPMsgs(buyReasonMaint, (BuyReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonMaintService) this._Channel).Load(this._UserProfile, buyReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonMaintMethod(buyReasonMaint, BuyReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BuyReasonMaint) null, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus Load(BuyReasonMaint buyReasonMaint)
    {
      return this.Load(buyReasonMaint, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus Load(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.Load(buyReasonMaint, (BuyReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_LoadESigDetails_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, buyReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonMaintMethod(buyReasonMaint, BuyReasonMaintMethods.LoadESigDetails, (BuyReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BuyReasonMaint) null, (BuyReasonMaint_LoadESigDetails_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(BuyReasonMaint buyReasonMaint)
    {
      return this.LoadESigDetails(buyReasonMaint, (BuyReasonMaint_LoadESigDetails_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.LoadESigDetails(buyReasonMaint, (BuyReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonMaintService) this._Channel).New(this._UserProfile, buyReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonMaintMethod(buyReasonMaint, BuyReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BuyReasonMaint) null, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus New(BuyReasonMaint buyReasonMaint)
    {
      return this.New(buyReasonMaint, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus New(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.New(buyReasonMaint, (BuyReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonMaintService) this._Channel).NewCopy(this._UserProfile, buyReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonMaintMethod(buyReasonMaint, BuyReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BuyReasonMaint) null, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus NewCopy(BuyReasonMaint buyReasonMaint)
    {
      return this.NewCopy(buyReasonMaint, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.NewCopy(buyReasonMaint, (BuyReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonMaintService) this._Channel).SaveAs(this._UserProfile, buyReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonMaintMethod(buyReasonMaint, BuyReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BuyReasonMaint) null, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus SaveAs(BuyReasonMaint buyReasonMaint)
    {
      return this.SaveAs(buyReasonMaint, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.SaveAs(buyReasonMaint, (BuyReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Parameters parameters,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonMaintService) this._Channel).UnFreeze(this._UserProfile, buyReasonMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonMaintMethod(buyReasonMaint, BuyReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) buyReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BuyReasonMaint) null, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(BuyReasonMaint buyReasonMaint)
    {
      return this.UnFreeze(buyReasonMaint, (BuyReasonMaint_Parameters) null, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BuyReasonMaint buyReasonMaint,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.UnFreeze(buyReasonMaint, (BuyReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject buyReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BuyReasonMaint) buyReasonMaint, (BuyReasonMaint_Parameters) parameters, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject buyReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BuyReasonMaint) buyReasonMaint, (BuyReasonMaint_Parameters) parameters, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject buyReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BuyReasonMaint) buyReasonMaint, (BuyReasonMaint_LoadESigDetails_Parameters) parameters, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject buyReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((BuyReasonMaint) buyReasonMaint, (BuyReasonMaint_Parameters) parameters, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject buyReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BuyReasonMaint) buyReasonMaint, (BuyReasonMaint_Parameters) parameters, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject buyReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BuyReasonMaint) buyReasonMaint, (BuyReasonMaint_Parameters) parameters, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject buyReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BuyReasonMaint) buyReasonMaint, (BuyReasonMaint_Parameters) parameters, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject buyReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((BuyReasonMaint) buyReasonMaint, (BuyReasonMaint_Parameters) parameters, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject buyReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BuyReasonMaint) buyReasonMaint, (BuyReasonMaint_Parameters) parameters, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      try
      {
        BuyReasonMaintMethod[] methods = new BuyReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBuyReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BuyReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BuyReasonMaint cdo,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      try
      {
        return ((IBuyReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BuyReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BuyReasonMaint) cdo, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.GetEnvironment((BuyReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BuyReasonMaint cdo,
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      result = (BuyReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BuyReasonMaintMethod(cdo, BuyReasonMaintMethods.ExecuteTransaction, (BuyReasonMaint_Parameters) null));
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
        BuyReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BuyReasonMaint) cdo, (BuyReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BuyReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BuyReasonMaint_Request) null, out BuyReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BuyReasonMaint_Request request,
      out BuyReasonMaint_Result result)
    {
      return this.ExecuteTransaction((BuyReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BuyReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BuyReasonMaintMethod(cdo, BuyReasonMaintMethods.AddDataTransaction, (BuyReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((BuyReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
