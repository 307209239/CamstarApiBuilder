// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShipmentDestinationGrpMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ShipmentDestinationGrpMaintService : NamedObjectGroupMaintBase
  {
    public ShipmentDestinationGrpMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IShipmentDestinationGrpMaintService), userProfile);
    }

    public ResultStatus Delete(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Parameters parameters,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationGrpMaintService) this._Channel).Delete(this._UserProfile, shipmentDestinationGrpMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(shipmentDestinationGrpMaint, ShipmentDestinationGrpMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ShipmentDestinationGrpMaint) null, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus Delete(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint)
    {
      return this.Delete(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus Delete(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.Delete(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Parameters parameters,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationGrpMaintService) this._Channel).Freeze(this._UserProfile, shipmentDestinationGrpMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(shipmentDestinationGrpMaint, ShipmentDestinationGrpMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ShipmentDestinationGrpMaint) null, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus Freeze(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint)
    {
      return this.Freeze(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus Freeze(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.Freeze(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Parameters parameters,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationGrpMaintService) this._Channel).GetWIPMsgs(this._UserProfile, shipmentDestinationGrpMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(shipmentDestinationGrpMaint, ShipmentDestinationGrpMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ShipmentDestinationGrpMaint) null, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint)
    {
      return this.GetWIPMsgs(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.GetWIPMsgs(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Parameters parameters,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationGrpMaintService) this._Channel).Load(this._UserProfile, shipmentDestinationGrpMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(shipmentDestinationGrpMaint, ShipmentDestinationGrpMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ShipmentDestinationGrpMaint) null, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus Load(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint)
    {
      return this.Load(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus Load(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.Load(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_LoadESigDetails_Parameters parameters,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationGrpMaintService) this._Channel).LoadESigDetails(this._UserProfile, shipmentDestinationGrpMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(shipmentDestinationGrpMaint, ShipmentDestinationGrpMaintMethods.LoadESigDetails, (ShipmentDestinationGrpMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ShipmentDestinationGrpMaint) null, (ShipmentDestinationGrpMaint_LoadESigDetails_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint)
    {
      return this.LoadESigDetails(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_LoadESigDetails_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.LoadESigDetails(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Parameters parameters,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationGrpMaintService) this._Channel).New(this._UserProfile, shipmentDestinationGrpMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(shipmentDestinationGrpMaint, ShipmentDestinationGrpMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ShipmentDestinationGrpMaint) null, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus New(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint)
    {
      return this.New(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus New(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.New(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Parameters parameters,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationGrpMaintService) this._Channel).NewCopy(this._UserProfile, shipmentDestinationGrpMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(shipmentDestinationGrpMaint, ShipmentDestinationGrpMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ShipmentDestinationGrpMaint) null, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus NewCopy(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint)
    {
      return this.NewCopy(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus NewCopy(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.NewCopy(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Parameters parameters,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationGrpMaintService) this._Channel).SaveAs(this._UserProfile, shipmentDestinationGrpMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(shipmentDestinationGrpMaint, ShipmentDestinationGrpMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ShipmentDestinationGrpMaint) null, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus SaveAs(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint)
    {
      return this.SaveAs(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus SaveAs(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.SaveAs(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Parameters parameters,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationGrpMaintService) this._Channel).UnFreeze(this._UserProfile, shipmentDestinationGrpMaint, parameters, request, out result) : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(shipmentDestinationGrpMaint, ShipmentDestinationGrpMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) shipmentDestinationGrpMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ShipmentDestinationGrpMaint) null, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint)
    {
      return this.UnFreeze(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ShipmentDestinationGrpMaint shipmentDestinationGrpMaint,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.UnFreeze(shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject shipmentDestinationGrpMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ShipmentDestinationGrpMaint) shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) parameters, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject shipmentDestinationGrpMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ShipmentDestinationGrpMaint) shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) parameters, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject shipmentDestinationGrpMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ShipmentDestinationGrpMaint) shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_LoadESigDetails_Parameters) parameters, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject shipmentDestinationGrpMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus resultStatus = this.New((ShipmentDestinationGrpMaint) shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) parameters, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject shipmentDestinationGrpMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ShipmentDestinationGrpMaint) shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) parameters, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject shipmentDestinationGrpMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ShipmentDestinationGrpMaint) shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) parameters, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject shipmentDestinationGrpMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ShipmentDestinationGrpMaint) shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) parameters, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject shipmentDestinationGrpMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus resultStatus = this.Load((ShipmentDestinationGrpMaint) shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) parameters, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject shipmentDestinationGrpMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ShipmentDestinationGrpMaint) shipmentDestinationGrpMaint, (ShipmentDestinationGrpMaint_Parameters) parameters, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      try
      {
        ShipmentDestinationGrpMaintMethod[] methods = new ShipmentDestinationGrpMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IShipmentDestinationGrpMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShipmentDestinationGrpMaint cdo,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      try
      {
        return ((IShipmentDestinationGrpMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ShipmentDestinationGrpMaint) cdo, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.GetEnvironment((ShipmentDestinationGrpMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ShipmentDestinationGrpMaint cdo,
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      result = (ShipmentDestinationGrpMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipmentDestinationGrpMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(cdo, ShipmentDestinationGrpMaintMethods.ExecuteTransaction, (ShipmentDestinationGrpMaint_Parameters) null));
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
        ShipmentDestinationGrpMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ShipmentDestinationGrpMaint) cdo, (ShipmentDestinationGrpMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ShipmentDestinationGrpMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ShipmentDestinationGrpMaint_Request) null, out ShipmentDestinationGrpMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ShipmentDestinationGrpMaint_Request request,
      out ShipmentDestinationGrpMaint_Result result)
    {
      return this.ExecuteTransaction((ShipmentDestinationGrpMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ShipmentDestinationGrpMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ShipmentDestinationGrpMaintMethod(cdo, ShipmentDestinationGrpMaintMethods.AddDataTransaction, (ShipmentDestinationGrpMaint_Parameters) null));
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
        return this.AddDataTransaction((ShipmentDestinationGrpMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
