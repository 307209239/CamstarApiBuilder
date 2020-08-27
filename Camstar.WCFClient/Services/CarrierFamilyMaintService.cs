// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CarrierFamilyMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CarrierFamilyMaintService : ResourceFamilyMaintBase
  {
    public CarrierFamilyMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICarrierFamilyMaintService), userProfile);
    }

    public ResultStatus Delete(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierFamilyMaintService) this._Channel).Delete(this._UserProfile, carrierFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierFamilyMaintMethod(carrierFamilyMaint, CarrierFamilyMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((CarrierFamilyMaint) null, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus Delete(CarrierFamilyMaint carrierFamilyMaint)
    {
      return this.Delete(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus Delete(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.Delete(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierFamilyMaintService) this._Channel).Freeze(this._UserProfile, carrierFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierFamilyMaintMethod(carrierFamilyMaint, CarrierFamilyMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((CarrierFamilyMaint) null, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus Freeze(CarrierFamilyMaint carrierFamilyMaint)
    {
      return this.Freeze(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus Freeze(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.Freeze(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierFamilyMaintService) this._Channel).GetWIPMsgs(this._UserProfile, carrierFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierFamilyMaintMethod(carrierFamilyMaint, CarrierFamilyMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CarrierFamilyMaint) null, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(CarrierFamilyMaint carrierFamilyMaint)
    {
      return this.GetWIPMsgs(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.GetWIPMsgs(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierFamilyMaintService) this._Channel).Load(this._UserProfile, carrierFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierFamilyMaintMethod(carrierFamilyMaint, CarrierFamilyMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CarrierFamilyMaint) null, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus Load(CarrierFamilyMaint carrierFamilyMaint)
    {
      return this.Load(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus Load(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.Load(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_LoadESigDetails_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierFamilyMaintService) this._Channel).LoadESigDetails(this._UserProfile, carrierFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierFamilyMaintMethod(carrierFamilyMaint, CarrierFamilyMaintMethods.LoadESigDetails, (CarrierFamilyMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CarrierFamilyMaint) null, (CarrierFamilyMaint_LoadESigDetails_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus LoadESigDetails(CarrierFamilyMaint carrierFamilyMaint)
    {
      return this.LoadESigDetails(carrierFamilyMaint, (CarrierFamilyMaint_LoadESigDetails_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.LoadESigDetails(carrierFamilyMaint, (CarrierFamilyMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierFamilyMaintService) this._Channel).New(this._UserProfile, carrierFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierFamilyMaintMethod(carrierFamilyMaint, CarrierFamilyMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((CarrierFamilyMaint) null, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus New(CarrierFamilyMaint carrierFamilyMaint)
    {
      return this.New(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus New(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.New(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierFamilyMaintService) this._Channel).NewCopy(this._UserProfile, carrierFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierFamilyMaintMethod(carrierFamilyMaint, CarrierFamilyMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((CarrierFamilyMaint) null, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus NewCopy(CarrierFamilyMaint carrierFamilyMaint)
    {
      return this.NewCopy(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus NewCopy(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.NewCopy(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierFamilyMaintService) this._Channel).SaveAs(this._UserProfile, carrierFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierFamilyMaintMethod(carrierFamilyMaint, CarrierFamilyMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((CarrierFamilyMaint) null, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus SaveAs(CarrierFamilyMaint carrierFamilyMaint)
    {
      return this.SaveAs(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus SaveAs(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.SaveAs(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Parameters parameters,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierFamilyMaintService) this._Channel).UnFreeze(this._UserProfile, carrierFamilyMaint, parameters, request, out result) : this.AddMethod((Method) new CarrierFamilyMaintMethod(carrierFamilyMaint, CarrierFamilyMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) carrierFamilyMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((CarrierFamilyMaint) null, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus UnFreeze(CarrierFamilyMaint carrierFamilyMaint)
    {
      return this.UnFreeze(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus UnFreeze(
      CarrierFamilyMaint carrierFamilyMaint,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.UnFreeze(carrierFamilyMaint, (CarrierFamilyMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject carrierFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Delete((CarrierFamilyMaint) carrierFamilyMaint, (CarrierFamilyMaint_Parameters) parameters, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject carrierFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((CarrierFamilyMaint) carrierFamilyMaint, (CarrierFamilyMaint_Parameters) parameters, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject carrierFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierFamilyMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CarrierFamilyMaint) carrierFamilyMaint, (CarrierFamilyMaint_LoadESigDetails_Parameters) parameters, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject carrierFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierFamilyMaint_Result result1;
        ResultStatus resultStatus = this.New((CarrierFamilyMaint) carrierFamilyMaint, (CarrierFamilyMaint_Parameters) parameters, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject carrierFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierFamilyMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((CarrierFamilyMaint) carrierFamilyMaint, (CarrierFamilyMaint_Parameters) parameters, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject carrierFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierFamilyMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((CarrierFamilyMaint) carrierFamilyMaint, (CarrierFamilyMaint_Parameters) parameters, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject carrierFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierFamilyMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((CarrierFamilyMaint) carrierFamilyMaint, (CarrierFamilyMaint_Parameters) parameters, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject carrierFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierFamilyMaint_Result result1;
        ResultStatus resultStatus = this.Load((CarrierFamilyMaint) carrierFamilyMaint, (CarrierFamilyMaint_Parameters) parameters, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject carrierFamilyMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CarrierFamilyMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CarrierFamilyMaint) carrierFamilyMaint, (CarrierFamilyMaint_Parameters) parameters, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      try
      {
        CarrierFamilyMaintMethod[] methods = new CarrierFamilyMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICarrierFamilyMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CarrierFamilyMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CarrierFamilyMaint cdo,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      try
      {
        return ((ICarrierFamilyMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CarrierFamilyMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((CarrierFamilyMaint) cdo, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.GetEnvironment((CarrierFamilyMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CarrierFamilyMaint cdo,
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      result = (CarrierFamilyMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICarrierFamilyMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CarrierFamilyMaintMethod(cdo, CarrierFamilyMaintMethods.ExecuteTransaction, (CarrierFamilyMaint_Parameters) null));
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
        CarrierFamilyMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CarrierFamilyMaint) cdo, (CarrierFamilyMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CarrierFamilyMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (CarrierFamilyMaint_Request) null, out CarrierFamilyMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CarrierFamilyMaint_Request request,
      out CarrierFamilyMaint_Result result)
    {
      return this.ExecuteTransaction((CarrierFamilyMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CarrierFamilyMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CarrierFamilyMaintMethod(cdo, CarrierFamilyMaintMethods.AddDataTransaction, (CarrierFamilyMaint_Parameters) null));
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
        return this.AddDataTransaction((CarrierFamilyMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
