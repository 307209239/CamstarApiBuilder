// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CarrierStatusReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CarrierStatusReasonMaintService : ResourceStatusReasonMaintBase
  {
    public CarrierStatusReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICarrierStatusReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusReasonMaintService) this._Channel).Delete(this._UserProfile, carrierStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(carrierStatusReasonMaint, CarrierStatusReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((CarrierStatusReasonMaint) null, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus Delete(CarrierStatusReasonMaint carrierStatusReasonMaint)
    {
      return this.Delete(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus Delete(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.Delete(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusReasonMaintService) this._Channel).Freeze(this._UserProfile, carrierStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(carrierStatusReasonMaint, CarrierStatusReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((CarrierStatusReasonMaint) null, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus Freeze(CarrierStatusReasonMaint carrierStatusReasonMaint)
    {
      return this.Freeze(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.Freeze(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, carrierStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(carrierStatusReasonMaint, CarrierStatusReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CarrierStatusReasonMaint) null, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(CarrierStatusReasonMaint carrierStatusReasonMaint)
    {
      return this.GetWIPMsgs(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.GetWIPMsgs(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusReasonMaintService) this._Channel).Load(this._UserProfile, carrierStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(carrierStatusReasonMaint, CarrierStatusReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CarrierStatusReasonMaint) null, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus Load(CarrierStatusReasonMaint carrierStatusReasonMaint)
    {
      return this.Load(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus Load(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.Load(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_LoadESigDetails_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, carrierStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(carrierStatusReasonMaint, CarrierStatusReasonMaintMethods.LoadESigDetails, (CarrierStatusReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CarrierStatusReasonMaint) null, (CarrierStatusReasonMaint_LoadESigDetails_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CarrierStatusReasonMaint carrierStatusReasonMaint)
    {
      return this.LoadESigDetails(carrierStatusReasonMaint, (CarrierStatusReasonMaint_LoadESigDetails_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.LoadESigDetails(carrierStatusReasonMaint, (CarrierStatusReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusReasonMaintService) this._Channel).New(this._UserProfile, carrierStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(carrierStatusReasonMaint, CarrierStatusReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((CarrierStatusReasonMaint) null, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus New(CarrierStatusReasonMaint carrierStatusReasonMaint)
    {
      return this.New(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus New(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.New(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusReasonMaintService) this._Channel).NewCopy(this._UserProfile, carrierStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(carrierStatusReasonMaint, CarrierStatusReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((CarrierStatusReasonMaint) null, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus NewCopy(CarrierStatusReasonMaint carrierStatusReasonMaint)
    {
      return this.NewCopy(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.NewCopy(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusReasonMaintService) this._Channel).SaveAs(this._UserProfile, carrierStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(carrierStatusReasonMaint, CarrierStatusReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((CarrierStatusReasonMaint) null, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus SaveAs(CarrierStatusReasonMaint carrierStatusReasonMaint)
    {
      return this.SaveAs(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.SaveAs(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Parameters parameters,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusReasonMaintService) this._Channel).UnFreeze(this._UserProfile, carrierStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(carrierStatusReasonMaint, CarrierStatusReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) carrierStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((CarrierStatusReasonMaint) null, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(CarrierStatusReasonMaint carrierStatusReasonMaint)
    {
      return this.UnFreeze(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CarrierStatusReasonMaint carrierStatusReasonMaint,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.UnFreeze(carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject carrierStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((CarrierStatusReasonMaint) carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) parameters, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject carrierStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((CarrierStatusReasonMaint) carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) parameters, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject carrierStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CarrierStatusReasonMaint) carrierStatusReasonMaint, (CarrierStatusReasonMaint_LoadESigDetails_Parameters) parameters, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject carrierStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((CarrierStatusReasonMaint) carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) parameters, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject carrierStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((CarrierStatusReasonMaint) carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) parameters, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject carrierStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((CarrierStatusReasonMaint) carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) parameters, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject carrierStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((CarrierStatusReasonMaint) carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) parameters, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject carrierStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((CarrierStatusReasonMaint) carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) parameters, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject carrierStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierStatusReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CarrierStatusReasonMaint) carrierStatusReasonMaint, (CarrierStatusReasonMaint_Parameters) parameters, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      try
      {
        CarrierStatusReasonMaintMethod[] methods = new CarrierStatusReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICarrierStatusReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CarrierStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CarrierStatusReasonMaint cdo,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      try
      {
        return ((ICarrierStatusReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CarrierStatusReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((CarrierStatusReasonMaint) cdo, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.GetEnvironment((CarrierStatusReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CarrierStatusReasonMaint cdo,
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      result = (CarrierStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierStatusReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(cdo, CarrierStatusReasonMaintMethods.ExecuteTransaction, (CarrierStatusReasonMaint_Parameters) null));
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
        CarrierStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CarrierStatusReasonMaint) cdo, (CarrierStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CarrierStatusReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (CarrierStatusReasonMaint_Request) null, out CarrierStatusReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CarrierStatusReasonMaint_Request request,
      out CarrierStatusReasonMaint_Result result)
    {
      return this.ExecuteTransaction((CarrierStatusReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CarrierStatusReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CarrierStatusReasonMaintMethod(cdo, CarrierStatusReasonMaintMethods.AddDataTransaction, (CarrierStatusReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((CarrierStatusReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
