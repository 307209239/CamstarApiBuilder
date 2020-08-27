// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BuyReasonGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BuyReasonGroupMaintService : UserCodeGroupMaintBase
  {
    public BuyReasonGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBuyReasonGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonGroupMaintService) this._Channel).Delete(this._UserProfile, buyReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonGroupMaintMethod(buyReasonGroupMaint, BuyReasonGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BuyReasonGroupMaint) null, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(BuyReasonGroupMaint buyReasonGroupMaint)
    {
      return this.Delete(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus Delete(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.Delete(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonGroupMaintService) this._Channel).Freeze(this._UserProfile, buyReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonGroupMaintMethod(buyReasonGroupMaint, BuyReasonGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BuyReasonGroupMaint) null, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(BuyReasonGroupMaint buyReasonGroupMaint)
    {
      return this.Freeze(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.Freeze(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, buyReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonGroupMaintMethod(buyReasonGroupMaint, BuyReasonGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BuyReasonGroupMaint) null, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BuyReasonGroupMaint buyReasonGroupMaint)
    {
      return this.GetWIPMsgs(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.GetWIPMsgs(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonGroupMaintService) this._Channel).Load(this._UserProfile, buyReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonGroupMaintMethod(buyReasonGroupMaint, BuyReasonGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BuyReasonGroupMaint) null, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus Load(BuyReasonGroupMaint buyReasonGroupMaint)
    {
      return this.Load(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus Load(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.Load(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_LoadESigDetails_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, buyReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonGroupMaintMethod(buyReasonGroupMaint, BuyReasonGroupMaintMethods.LoadESigDetails, (BuyReasonGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BuyReasonGroupMaint) null, (BuyReasonGroupMaint_LoadESigDetails_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(BuyReasonGroupMaint buyReasonGroupMaint)
    {
      return this.LoadESigDetails(buyReasonGroupMaint, (BuyReasonGroupMaint_LoadESigDetails_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.LoadESigDetails(buyReasonGroupMaint, (BuyReasonGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonGroupMaintService) this._Channel).New(this._UserProfile, buyReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonGroupMaintMethod(buyReasonGroupMaint, BuyReasonGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BuyReasonGroupMaint) null, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus New(BuyReasonGroupMaint buyReasonGroupMaint)
    {
      return this.New(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus New(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.New(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonGroupMaintService) this._Channel).NewCopy(this._UserProfile, buyReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonGroupMaintMethod(buyReasonGroupMaint, BuyReasonGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BuyReasonGroupMaint) null, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(BuyReasonGroupMaint buyReasonGroupMaint)
    {
      return this.NewCopy(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.NewCopy(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonGroupMaintService) this._Channel).SaveAs(this._UserProfile, buyReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonGroupMaintMethod(buyReasonGroupMaint, BuyReasonGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BuyReasonGroupMaint) null, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(BuyReasonGroupMaint buyReasonGroupMaint)
    {
      return this.SaveAs(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.SaveAs(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Parameters parameters,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonGroupMaintService) this._Channel).UnFreeze(this._UserProfile, buyReasonGroupMaint, parameters, request, out result) : this.AddMethod((Method) new BuyReasonGroupMaintMethod(buyReasonGroupMaint, BuyReasonGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) buyReasonGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BuyReasonGroupMaint) null, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(BuyReasonGroupMaint buyReasonGroupMaint)
    {
      return this.UnFreeze(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BuyReasonGroupMaint buyReasonGroupMaint,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.UnFreeze(buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject buyReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BuyReasonGroupMaint) buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) parameters, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject buyReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BuyReasonGroupMaint) buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) parameters, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject buyReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BuyReasonGroupMaint) buyReasonGroupMaint, (BuyReasonGroupMaint_LoadESigDetails_Parameters) parameters, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject buyReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((BuyReasonGroupMaint) buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) parameters, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject buyReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BuyReasonGroupMaint) buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) parameters, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject buyReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BuyReasonGroupMaint) buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) parameters, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject buyReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BuyReasonGroupMaint) buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) parameters, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject buyReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((BuyReasonGroupMaint) buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) parameters, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject buyReasonGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BuyReasonGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BuyReasonGroupMaint) buyReasonGroupMaint, (BuyReasonGroupMaint_Parameters) parameters, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      try
      {
        BuyReasonGroupMaintMethod[] methods = new BuyReasonGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBuyReasonGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BuyReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BuyReasonGroupMaint cdo,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      try
      {
        return ((IBuyReasonGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BuyReasonGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BuyReasonGroupMaint) cdo, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.GetEnvironment((BuyReasonGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BuyReasonGroupMaint cdo,
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      result = (BuyReasonGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBuyReasonGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BuyReasonGroupMaintMethod(cdo, BuyReasonGroupMaintMethods.ExecuteTransaction, (BuyReasonGroupMaint_Parameters) null));
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
        BuyReasonGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BuyReasonGroupMaint) cdo, (BuyReasonGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BuyReasonGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BuyReasonGroupMaint_Request) null, out BuyReasonGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BuyReasonGroupMaint_Request request,
      out BuyReasonGroupMaint_Result result)
    {
      return this.ExecuteTransaction((BuyReasonGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BuyReasonGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BuyReasonGroupMaintMethod(cdo, BuyReasonGroupMaintMethods.AddDataTransaction, (BuyReasonGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((BuyReasonGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
