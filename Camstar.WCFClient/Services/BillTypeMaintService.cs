// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.BillTypeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class BillTypeMaintService : UserCodeMaintBase
  {
    public BillTypeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IBillTypeMaintService), userProfile);
    }

    public ResultStatus Delete(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) billTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillTypeMaintService) this._Channel).Delete(this._UserProfile, billTypeMaint, parameters, request, out result) : this.AddMethod((Method) new BillTypeMaintMethod(billTypeMaint, BillTypeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) billTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((BillTypeMaint) null, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus Delete(BillTypeMaint billTypeMaint)
    {
      return this.Delete(billTypeMaint, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus Delete(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.Delete(billTypeMaint, (BillTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) billTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillTypeMaintService) this._Channel).Freeze(this._UserProfile, billTypeMaint, parameters, request, out result) : this.AddMethod((Method) new BillTypeMaintMethod(billTypeMaint, BillTypeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) billTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((BillTypeMaint) null, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus Freeze(BillTypeMaint billTypeMaint)
    {
      return this.Freeze(billTypeMaint, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus Freeze(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.Freeze(billTypeMaint, (BillTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) billTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillTypeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, billTypeMaint, parameters, request, out result) : this.AddMethod((Method) new BillTypeMaintMethod(billTypeMaint, BillTypeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) billTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((BillTypeMaint) null, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(BillTypeMaint billTypeMaint)
    {
      return this.GetWIPMsgs(billTypeMaint, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.GetWIPMsgs(billTypeMaint, (BillTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) billTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillTypeMaintService) this._Channel).Load(this._UserProfile, billTypeMaint, parameters, request, out result) : this.AddMethod((Method) new BillTypeMaintMethod(billTypeMaint, BillTypeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) billTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((BillTypeMaint) null, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus Load(BillTypeMaint billTypeMaint)
    {
      return this.Load(billTypeMaint, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus Load(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.Load(billTypeMaint, (BillTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_LoadESigDetails_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) billTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillTypeMaintService) this._Channel).LoadESigDetails(this._UserProfile, billTypeMaint, parameters, request, out result) : this.AddMethod((Method) new BillTypeMaintMethod(billTypeMaint, BillTypeMaintMethods.LoadESigDetails, (BillTypeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) billTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((BillTypeMaint) null, (BillTypeMaint_LoadESigDetails_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(BillTypeMaint billTypeMaint)
    {
      return this.LoadESigDetails(billTypeMaint, (BillTypeMaint_LoadESigDetails_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.LoadESigDetails(billTypeMaint, (BillTypeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) billTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillTypeMaintService) this._Channel).New(this._UserProfile, billTypeMaint, parameters, request, out result) : this.AddMethod((Method) new BillTypeMaintMethod(billTypeMaint, BillTypeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) billTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((BillTypeMaint) null, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus New(BillTypeMaint billTypeMaint)
    {
      return this.New(billTypeMaint, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus New(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.New(billTypeMaint, (BillTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) billTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillTypeMaintService) this._Channel).NewCopy(this._UserProfile, billTypeMaint, parameters, request, out result) : this.AddMethod((Method) new BillTypeMaintMethod(billTypeMaint, BillTypeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) billTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((BillTypeMaint) null, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus NewCopy(BillTypeMaint billTypeMaint)
    {
      return this.NewCopy(billTypeMaint, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus NewCopy(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.NewCopy(billTypeMaint, (BillTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) billTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillTypeMaintService) this._Channel).SaveAs(this._UserProfile, billTypeMaint, parameters, request, out result) : this.AddMethod((Method) new BillTypeMaintMethod(billTypeMaint, BillTypeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) billTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((BillTypeMaint) null, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus SaveAs(BillTypeMaint billTypeMaint)
    {
      return this.SaveAs(billTypeMaint, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus SaveAs(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.SaveAs(billTypeMaint, (BillTypeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Parameters parameters,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) billTypeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillTypeMaintService) this._Channel).UnFreeze(this._UserProfile, billTypeMaint, parameters, request, out result) : this.AddMethod((Method) new BillTypeMaintMethod(billTypeMaint, BillTypeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) billTypeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((BillTypeMaint) null, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(BillTypeMaint billTypeMaint)
    {
      return this.UnFreeze(billTypeMaint, (BillTypeMaint_Parameters) null, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      BillTypeMaint billTypeMaint,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.UnFreeze(billTypeMaint, (BillTypeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject billTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillTypeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((BillTypeMaint) billTypeMaint, (BillTypeMaint_Parameters) parameters, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject billTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillTypeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((BillTypeMaint) billTypeMaint, (BillTypeMaint_Parameters) parameters, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject billTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillTypeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((BillTypeMaint) billTypeMaint, (BillTypeMaint_LoadESigDetails_Parameters) parameters, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject billTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillTypeMaint_Result result1;
        ResultStatus resultStatus = this.New((BillTypeMaint) billTypeMaint, (BillTypeMaint_Parameters) parameters, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject billTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillTypeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((BillTypeMaint) billTypeMaint, (BillTypeMaint_Parameters) parameters, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject billTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillTypeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((BillTypeMaint) billTypeMaint, (BillTypeMaint_Parameters) parameters, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject billTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillTypeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((BillTypeMaint) billTypeMaint, (BillTypeMaint_Parameters) parameters, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject billTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillTypeMaint_Result result1;
        ResultStatus resultStatus = this.Load((BillTypeMaint) billTypeMaint, (BillTypeMaint_Parameters) parameters, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject billTypeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        BillTypeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((BillTypeMaint) billTypeMaint, (BillTypeMaint_Parameters) parameters, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      try
      {
        BillTypeMaintMethod[] methods = new BillTypeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IBillTypeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        BillTypeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BillTypeMaint cdo,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      try
      {
        return ((IBillTypeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        BillTypeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((BillTypeMaint) cdo, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.GetEnvironment((BillTypeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      BillTypeMaint cdo,
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      result = (BillTypeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IBillTypeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new BillTypeMaintMethod(cdo, BillTypeMaintMethods.ExecuteTransaction, (BillTypeMaint_Parameters) null));
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
        BillTypeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((BillTypeMaint) cdo, (BillTypeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(BillTypeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (BillTypeMaint_Request) null, out BillTypeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      BillTypeMaint_Request request,
      out BillTypeMaint_Result result)
    {
      return this.ExecuteTransaction((BillTypeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(BillTypeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new BillTypeMaintMethod(cdo, BillTypeMaintMethods.AddDataTransaction, (BillTypeMaint_Parameters) null));
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
        return this.AddDataTransaction((BillTypeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
