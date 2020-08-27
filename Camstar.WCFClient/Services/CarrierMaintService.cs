// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CarrierMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CarrierMaintService : ResourceMaintBase
  {
    public CarrierMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICarrierMaintService), userProfile);
    }

    public ResultStatus Delete(
      CarrierMaint carrierMaint,
      CarrierMaint_Parameters parameters,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) carrierMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierMaintService) this._Channel).Delete(this._UserProfile, carrierMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierMaintMethod(carrierMaint, CarrierMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) carrierMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((CarrierMaint) null, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus Delete(CarrierMaint carrierMaint)
    {
      return this.Delete(carrierMaint, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus Delete(
      CarrierMaint carrierMaint,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.Delete(carrierMaint, (CarrierMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      CarrierMaint carrierMaint,
      CarrierMaint_Parameters parameters,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) carrierMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierMaintService) this._Channel).Freeze(this._UserProfile, carrierMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierMaintMethod(carrierMaint, CarrierMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) carrierMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((CarrierMaint) null, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus Freeze(CarrierMaint carrierMaint)
    {
      return this.Freeze(carrierMaint, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus Freeze(
      CarrierMaint carrierMaint,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.Freeze(carrierMaint, (CarrierMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CarrierMaint carrierMaint,
      CarrierMaint_Parameters parameters,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) carrierMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierMaintService) this._Channel).GetWIPMsgs(this._UserProfile, carrierMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierMaintMethod(carrierMaint, CarrierMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) carrierMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CarrierMaint) null, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(CarrierMaint carrierMaint)
    {
      return this.GetWIPMsgs(carrierMaint, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CarrierMaint carrierMaint,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.GetWIPMsgs(carrierMaint, (CarrierMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CarrierMaint carrierMaint,
      CarrierMaint_Parameters parameters,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) carrierMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierMaintService) this._Channel).Load(this._UserProfile, carrierMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierMaintMethod(carrierMaint, CarrierMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) carrierMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CarrierMaint) null, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus Load(CarrierMaint carrierMaint)
    {
      return this.Load(carrierMaint, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus Load(
      CarrierMaint carrierMaint,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.Load(carrierMaint, (CarrierMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CarrierMaint carrierMaint,
      CarrierMaint_LoadESigDetails_Parameters parameters,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) carrierMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierMaintService) this._Channel).LoadESigDetails(this._UserProfile, carrierMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierMaintMethod(carrierMaint, CarrierMaintMethods.LoadESigDetails, (CarrierMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) carrierMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CarrierMaint) null, (CarrierMaint_LoadESigDetails_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus LoadESigDetails(CarrierMaint carrierMaint)
    {
      return this.LoadESigDetails(carrierMaint, (CarrierMaint_LoadESigDetails_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CarrierMaint carrierMaint,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.LoadESigDetails(carrierMaint, (CarrierMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      CarrierMaint carrierMaint,
      CarrierMaint_Parameters parameters,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) carrierMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierMaintService) this._Channel).New(this._UserProfile, carrierMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierMaintMethod(carrierMaint, CarrierMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) carrierMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((CarrierMaint) null, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus New(CarrierMaint carrierMaint)
    {
      return this.New(carrierMaint, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus New(
      CarrierMaint carrierMaint,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.New(carrierMaint, (CarrierMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      CarrierMaint carrierMaint,
      CarrierMaint_Parameters parameters,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) carrierMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierMaintService) this._Channel).NewCopy(this._UserProfile, carrierMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierMaintMethod(carrierMaint, CarrierMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) carrierMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((CarrierMaint) null, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus NewCopy(CarrierMaint carrierMaint)
    {
      return this.NewCopy(carrierMaint, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus NewCopy(
      CarrierMaint carrierMaint,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.NewCopy(carrierMaint, (CarrierMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      CarrierMaint carrierMaint,
      CarrierMaint_Parameters parameters,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) carrierMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierMaintService) this._Channel).SaveAs(this._UserProfile, carrierMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierMaintMethod(carrierMaint, CarrierMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) carrierMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((CarrierMaint) null, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus SaveAs(CarrierMaint carrierMaint)
    {
      return this.SaveAs(carrierMaint, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus SaveAs(
      CarrierMaint carrierMaint,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.SaveAs(carrierMaint, (CarrierMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      CarrierMaint carrierMaint,
      CarrierMaint_Parameters parameters,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) carrierMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierMaintService) this._Channel).UnFreeze(this._UserProfile, carrierMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierMaintMethod(carrierMaint, CarrierMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) carrierMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((CarrierMaint) null, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus UnFreeze(CarrierMaint carrierMaint)
    {
      return this.UnFreeze(carrierMaint, (CarrierMaint_Parameters) null, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CarrierMaint carrierMaint,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.UnFreeze(carrierMaint, (CarrierMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject carrierMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierMaint_Result result1;
        ResultStatus resultStatus = this.Delete((CarrierMaint) carrierMaint, (CarrierMaint_Parameters) parameters, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject carrierMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((CarrierMaint) carrierMaint, (CarrierMaint_Parameters) parameters, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject carrierMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CarrierMaint) carrierMaint, (CarrierMaint_LoadESigDetails_Parameters) parameters, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject carrierMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierMaint_Result result1;
        ResultStatus resultStatus = this.New((CarrierMaint) carrierMaint, (CarrierMaint_Parameters) parameters, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject carrierMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((CarrierMaint) carrierMaint, (CarrierMaint_Parameters) parameters, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject carrierMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((CarrierMaint) carrierMaint, (CarrierMaint_Parameters) parameters, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject carrierMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((CarrierMaint) carrierMaint, (CarrierMaint_Parameters) parameters, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject carrierMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierMaint_Result result1;
        ResultStatus resultStatus = this.Load((CarrierMaint) carrierMaint, (CarrierMaint_Parameters) parameters, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject carrierMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CarrierMaint) carrierMaint, (CarrierMaint_Parameters) parameters, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      try
      {
        CarrierMaintMethod[] methods = new CarrierMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICarrierMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CarrierMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CarrierMaint cdo,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      try
      {
        return ((ICarrierMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CarrierMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((CarrierMaint) cdo, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.GetEnvironment((CarrierMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CarrierMaint cdo,
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      result = (CarrierMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CarrierMaintMethod(cdo, CarrierMaintMethods.ExecuteTransaction, (CarrierMaint_Parameters) null));
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
        CarrierMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CarrierMaint) cdo, (CarrierMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CarrierMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (CarrierMaint_Request) null, out CarrierMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CarrierMaint_Request request,
      out CarrierMaint_Result result)
    {
      return this.ExecuteTransaction((CarrierMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CarrierMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CarrierMaintMethod(cdo, CarrierMaintMethods.AddDataTransaction, (CarrierMaint_Parameters) null));
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
        return this.AddDataTransaction((CarrierMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
