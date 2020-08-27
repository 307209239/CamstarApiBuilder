// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CarrierStatusCodeMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CarrierStatusCodeMaintService : ResourceStatusCodeMaintBase
  {
    public CarrierStatusCodeMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICarrierStatusCodeMaintService), userProfile);
    }

    public ResultStatus Delete(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusCodeMaintService) this._Channel).Delete(this._UserProfile, carrierStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(carrierStatusCodeMaint, CarrierStatusCodeMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((CarrierStatusCodeMaint) null, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus Delete(CarrierStatusCodeMaint carrierStatusCodeMaint)
    {
      return this.Delete(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus Delete(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.Delete(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusCodeMaintService) this._Channel).Freeze(this._UserProfile, carrierStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(carrierStatusCodeMaint, CarrierStatusCodeMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((CarrierStatusCodeMaint) null, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus Freeze(CarrierStatusCodeMaint carrierStatusCodeMaint)
    {
      return this.Freeze(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus Freeze(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.Freeze(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusCodeMaintService) this._Channel).GetWIPMsgs(this._UserProfile, carrierStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(carrierStatusCodeMaint, CarrierStatusCodeMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CarrierStatusCodeMaint) null, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(CarrierStatusCodeMaint carrierStatusCodeMaint)
    {
      return this.GetWIPMsgs(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.GetWIPMsgs(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusCodeMaintService) this._Channel).Load(this._UserProfile, carrierStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(carrierStatusCodeMaint, CarrierStatusCodeMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CarrierStatusCodeMaint) null, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus Load(CarrierStatusCodeMaint carrierStatusCodeMaint)
    {
      return this.Load(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus Load(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.Load(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_LoadESigDetails_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusCodeMaintService) this._Channel).LoadESigDetails(this._UserProfile, carrierStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(carrierStatusCodeMaint, CarrierStatusCodeMaintMethods.LoadESigDetails, (CarrierStatusCodeMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CarrierStatusCodeMaint) null, (CarrierStatusCodeMaint_LoadESigDetails_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(CarrierStatusCodeMaint carrierStatusCodeMaint)
    {
      return this.LoadESigDetails(carrierStatusCodeMaint, (CarrierStatusCodeMaint_LoadESigDetails_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.LoadESigDetails(carrierStatusCodeMaint, (CarrierStatusCodeMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusCodeMaintService) this._Channel).New(this._UserProfile, carrierStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(carrierStatusCodeMaint, CarrierStatusCodeMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((CarrierStatusCodeMaint) null, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus New(CarrierStatusCodeMaint carrierStatusCodeMaint)
    {
      return this.New(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus New(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.New(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusCodeMaintService) this._Channel).NewCopy(this._UserProfile, carrierStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(carrierStatusCodeMaint, CarrierStatusCodeMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((CarrierStatusCodeMaint) null, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus NewCopy(CarrierStatusCodeMaint carrierStatusCodeMaint)
    {
      return this.NewCopy(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus NewCopy(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.NewCopy(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusCodeMaintService) this._Channel).SaveAs(this._UserProfile, carrierStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(carrierStatusCodeMaint, CarrierStatusCodeMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((CarrierStatusCodeMaint) null, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus SaveAs(CarrierStatusCodeMaint carrierStatusCodeMaint)
    {
      return this.SaveAs(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus SaveAs(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.SaveAs(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Parameters parameters,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusCodeMaintService) this._Channel).UnFreeze(this._UserProfile, carrierStatusCodeMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(carrierStatusCodeMaint, CarrierStatusCodeMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) carrierStatusCodeMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((CarrierStatusCodeMaint) null, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(CarrierStatusCodeMaint carrierStatusCodeMaint)
    {
      return this.UnFreeze(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CarrierStatusCodeMaint carrierStatusCodeMaint,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.UnFreeze(carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject carrierStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.Delete((CarrierStatusCodeMaint) carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) parameters, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject carrierStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((CarrierStatusCodeMaint) carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) parameters, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject carrierStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CarrierStatusCodeMaint) carrierStatusCodeMaint, (CarrierStatusCodeMaint_LoadESigDetails_Parameters) parameters, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject carrierStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.New((CarrierStatusCodeMaint) carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) parameters, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject carrierStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((CarrierStatusCodeMaint) carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) parameters, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject carrierStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((CarrierStatusCodeMaint) carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) parameters, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject carrierStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((CarrierStatusCodeMaint) carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) parameters, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject carrierStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.Load((CarrierStatusCodeMaint) carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) parameters, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject carrierStatusCodeMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusCodeMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CarrierStatusCodeMaint) carrierStatusCodeMaint, (CarrierStatusCodeMaint_Parameters) parameters, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      try
      {
        CarrierStatusCodeMaintMethod[] methods = new CarrierStatusCodeMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICarrierStatusCodeMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CarrierStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CarrierStatusCodeMaint cdo,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      try
      {
        return ((ICarrierStatusCodeMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CarrierStatusCodeMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((CarrierStatusCodeMaint) cdo, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.GetEnvironment((CarrierStatusCodeMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CarrierStatusCodeMaint cdo,
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      result = (CarrierStatusCodeMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusCodeMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(cdo, CarrierStatusCodeMaintMethods.ExecuteTransaction, (CarrierStatusCodeMaint_Parameters) null));
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
        CarrierStatusCodeMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CarrierStatusCodeMaint) cdo, (CarrierStatusCodeMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CarrierStatusCodeMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (CarrierStatusCodeMaint_Request) null, out CarrierStatusCodeMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CarrierStatusCodeMaint_Request request,
      out CarrierStatusCodeMaint_Result result)
    {
      return this.ExecuteTransaction((CarrierStatusCodeMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CarrierStatusCodeMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CarrierStatusCodeMaintMethod(cdo, CarrierStatusCodeMaintMethods.AddDataTransaction, (CarrierStatusCodeMaint_Parameters) null));
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
        return this.AddDataTransaction((CarrierStatusCodeMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
