// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CarrierGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CarrierGroupMaintService : ResourceGroupMaintBase
  {
    public CarrierGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICarrierGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierGroupMaintService) this._Channel).Delete(this._UserProfile, carrierGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierGroupMaintMethod(carrierGroupMaint, CarrierGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((CarrierGroupMaint) null, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus Delete(CarrierGroupMaint carrierGroupMaint)
    {
      return this.Delete(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus Delete(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.Delete(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierGroupMaintService) this._Channel).Freeze(this._UserProfile, carrierGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierGroupMaintMethod(carrierGroupMaint, CarrierGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((CarrierGroupMaint) null, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus Freeze(CarrierGroupMaint carrierGroupMaint)
    {
      return this.Freeze(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.Freeze(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, carrierGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierGroupMaintMethod(carrierGroupMaint, CarrierGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CarrierGroupMaint) null, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(CarrierGroupMaint carrierGroupMaint)
    {
      return this.GetWIPMsgs(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.GetWIPMsgs(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierGroupMaintService) this._Channel).Load(this._UserProfile, carrierGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierGroupMaintMethod(carrierGroupMaint, CarrierGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CarrierGroupMaint) null, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus Load(CarrierGroupMaint carrierGroupMaint)
    {
      return this.Load(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus Load(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.Load(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_LoadESigDetails_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, carrierGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierGroupMaintMethod(carrierGroupMaint, CarrierGroupMaintMethods.LoadESigDetails, (CarrierGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CarrierGroupMaint) null, (CarrierGroupMaint_LoadESigDetails_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(CarrierGroupMaint carrierGroupMaint)
    {
      return this.LoadESigDetails(carrierGroupMaint, (CarrierGroupMaint_LoadESigDetails_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.LoadESigDetails(carrierGroupMaint, (CarrierGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierGroupMaintService) this._Channel).New(this._UserProfile, carrierGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierGroupMaintMethod(carrierGroupMaint, CarrierGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((CarrierGroupMaint) null, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus New(CarrierGroupMaint carrierGroupMaint)
    {
      return this.New(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus New(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.New(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierGroupMaintService) this._Channel).NewCopy(this._UserProfile, carrierGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierGroupMaintMethod(carrierGroupMaint, CarrierGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((CarrierGroupMaint) null, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus NewCopy(CarrierGroupMaint carrierGroupMaint)
    {
      return this.NewCopy(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.NewCopy(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierGroupMaintService) this._Channel).SaveAs(this._UserProfile, carrierGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierGroupMaintMethod(carrierGroupMaint, CarrierGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((CarrierGroupMaint) null, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus SaveAs(CarrierGroupMaint carrierGroupMaint)
    {
      return this.SaveAs(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.SaveAs(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Parameters parameters,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierGroupMaintService) this._Channel).UnFreeze(this._UserProfile, carrierGroupMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierGroupMaintMethod(carrierGroupMaint, CarrierGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) carrierGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((CarrierGroupMaint) null, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(CarrierGroupMaint carrierGroupMaint)
    {
      return this.UnFreeze(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CarrierGroupMaint carrierGroupMaint,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.UnFreeze(carrierGroupMaint, (CarrierGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject carrierGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((CarrierGroupMaint) carrierGroupMaint, (CarrierGroupMaint_Parameters) parameters, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject carrierGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((CarrierGroupMaint) carrierGroupMaint, (CarrierGroupMaint_Parameters) parameters, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject carrierGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CarrierGroupMaint) carrierGroupMaint, (CarrierGroupMaint_LoadESigDetails_Parameters) parameters, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject carrierGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((CarrierGroupMaint) carrierGroupMaint, (CarrierGroupMaint_Parameters) parameters, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject carrierGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((CarrierGroupMaint) carrierGroupMaint, (CarrierGroupMaint_Parameters) parameters, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject carrierGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((CarrierGroupMaint) carrierGroupMaint, (CarrierGroupMaint_Parameters) parameters, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject carrierGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((CarrierGroupMaint) carrierGroupMaint, (CarrierGroupMaint_Parameters) parameters, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject carrierGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((CarrierGroupMaint) carrierGroupMaint, (CarrierGroupMaint_Parameters) parameters, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject carrierGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CarrierGroupMaint) carrierGroupMaint, (CarrierGroupMaint_Parameters) parameters, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      try
      {
        CarrierGroupMaintMethod[] methods = new CarrierGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICarrierGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CarrierGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CarrierGroupMaint cdo,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      try
      {
        return ((ICarrierGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CarrierGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((CarrierGroupMaint) cdo, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.GetEnvironment((CarrierGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CarrierGroupMaint cdo,
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      result = (CarrierGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CarrierGroupMaintMethod(cdo, CarrierGroupMaintMethods.ExecuteTransaction, (CarrierGroupMaint_Parameters) null));
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
        CarrierGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CarrierGroupMaint) cdo, (CarrierGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CarrierGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (CarrierGroupMaint_Request) null, out CarrierGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CarrierGroupMaint_Request request,
      out CarrierGroupMaint_Result result)
    {
      return this.ExecuteTransaction((CarrierGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CarrierGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CarrierGroupMaintMethod(cdo, CarrierGroupMaintMethods.AddDataTransaction, (CarrierGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((CarrierGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
