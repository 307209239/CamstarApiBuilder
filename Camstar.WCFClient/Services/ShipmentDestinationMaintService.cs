// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShipmentDestinationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ShipmentDestinationMaintService : NamedDataObjectMaintBase
  {
    public ShipmentDestinationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IShipmentDestinationMaintService), userProfile);
    }

    public ResultStatus Delete(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationMaintService) this._Channel).Delete(this._UserProfile, shipmentDestinationMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationMaintMethod(shipmentDestinationMaint, ShipmentDestinationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ShipmentDestinationMaint) null, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus Delete(ShipmentDestinationMaint shipmentDestinationMaint)
    {
      return this.Delete(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus Delete(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.Delete(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationMaintService) this._Channel).Freeze(this._UserProfile, shipmentDestinationMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationMaintMethod(shipmentDestinationMaint, ShipmentDestinationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ShipmentDestinationMaint) null, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus Freeze(ShipmentDestinationMaint shipmentDestinationMaint)
    {
      return this.Freeze(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus Freeze(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.Freeze(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, shipmentDestinationMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationMaintMethod(shipmentDestinationMaint, ShipmentDestinationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ShipmentDestinationMaint) null, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ShipmentDestinationMaint shipmentDestinationMaint)
    {
      return this.GetWIPMsgs(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.GetWIPMsgs(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationMaintService) this._Channel).Load(this._UserProfile, shipmentDestinationMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationMaintMethod(shipmentDestinationMaint, ShipmentDestinationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ShipmentDestinationMaint) null, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus Load(ShipmentDestinationMaint shipmentDestinationMaint)
    {
      return this.Load(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus Load(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.Load(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_LoadESigDetails_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationMaintService) this._Channel).LoadESigDetails(this._UserProfile, shipmentDestinationMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationMaintMethod(shipmentDestinationMaint, ShipmentDestinationMaintMethods.LoadESigDetails, (ShipmentDestinationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ShipmentDestinationMaint) null, (ShipmentDestinationMaint_LoadESigDetails_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ShipmentDestinationMaint shipmentDestinationMaint)
    {
      return this.LoadESigDetails(shipmentDestinationMaint, (ShipmentDestinationMaint_LoadESigDetails_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.LoadESigDetails(shipmentDestinationMaint, (ShipmentDestinationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationMaintService) this._Channel).New(this._UserProfile, shipmentDestinationMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationMaintMethod(shipmentDestinationMaint, ShipmentDestinationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ShipmentDestinationMaint) null, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus New(ShipmentDestinationMaint shipmentDestinationMaint)
    {
      return this.New(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus New(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.New(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationMaintService) this._Channel).NewCopy(this._UserProfile, shipmentDestinationMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationMaintMethod(shipmentDestinationMaint, ShipmentDestinationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ShipmentDestinationMaint) null, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus NewCopy(ShipmentDestinationMaint shipmentDestinationMaint)
    {
      return this.NewCopy(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus NewCopy(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.NewCopy(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationMaintService) this._Channel).SaveAs(this._UserProfile, shipmentDestinationMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationMaintMethod(shipmentDestinationMaint, ShipmentDestinationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ShipmentDestinationMaint) null, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus SaveAs(ShipmentDestinationMaint shipmentDestinationMaint)
    {
      return this.SaveAs(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus SaveAs(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.SaveAs(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Parameters parameters,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationMaintService) this._Channel).UnFreeze(this._UserProfile, shipmentDestinationMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationMaintMethod(shipmentDestinationMaint, ShipmentDestinationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) shipmentDestinationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ShipmentDestinationMaint) null, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus UnFreeze(ShipmentDestinationMaint shipmentDestinationMaint)
    {
      return this.UnFreeze(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ShipmentDestinationMaint shipmentDestinationMaint,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.UnFreeze(shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject shipmentDestinationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ShipmentDestinationMaint) shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) parameters, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject shipmentDestinationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ShipmentDestinationMaint) shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) parameters, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject shipmentDestinationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ShipmentDestinationMaint) shipmentDestinationMaint, (ShipmentDestinationMaint_LoadESigDetails_Parameters) parameters, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject shipmentDestinationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationMaint_Result result1;
        ResultStatus resultStatus = this.New((ShipmentDestinationMaint) shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) parameters, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject shipmentDestinationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ShipmentDestinationMaint) shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) parameters, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject shipmentDestinationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ShipmentDestinationMaint) shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) parameters, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject shipmentDestinationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ShipmentDestinationMaint) shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) parameters, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject shipmentDestinationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationMaint_Result result1;
        ResultStatus resultStatus = this.Load((ShipmentDestinationMaint) shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) parameters, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject shipmentDestinationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ShipmentDestinationMaint) shipmentDestinationMaint, (ShipmentDestinationMaint_Parameters) parameters, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      try
      {
        ShipmentDestinationMaintMethod[] methods = new ShipmentDestinationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IShipmentDestinationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ShipmentDestinationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShipmentDestinationMaint cdo,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      try
      {
        return ((IShipmentDestinationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ShipmentDestinationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ShipmentDestinationMaint) cdo, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.GetEnvironment((ShipmentDestinationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ShipmentDestinationMaint cdo,
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      result = (ShipmentDestinationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ShipmentDestinationMaintMethod(cdo, ShipmentDestinationMaintMethods.ExecuteTransaction, (ShipmentDestinationMaint_Parameters) null));
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
        ShipmentDestinationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ShipmentDestinationMaint) cdo, (ShipmentDestinationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ShipmentDestinationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ShipmentDestinationMaint_Request) null, out ShipmentDestinationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ShipmentDestinationMaint_Request request,
      out ShipmentDestinationMaint_Result result)
    {
      return this.ExecuteTransaction((ShipmentDestinationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ShipmentDestinationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ShipmentDestinationMaintMethod(cdo, ShipmentDestinationMaintMethods.AddDataTransaction, (ShipmentDestinationMaint_Parameters) null));
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
        return this.AddDataTransaction((ShipmentDestinationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
