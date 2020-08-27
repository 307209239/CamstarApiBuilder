// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShipService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ShipService : MoveNonStdBase
  {
    public ShipService(UserProfile userProfile)
    {
      this.Initialize(typeof (IShipService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result)
    {
      result = (Ship_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) ship, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipService) this._Channel).CreateParametricData(this._UserProfile, ship, parameters, request, out result) : this.AddMethod((Method) new ShipMethod(ship, ShipMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) ship, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Ship) null, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus CreateParametricData(Ship ship)
    {
      return this.CreateParametricData(ship, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus CreateParametricData(
      Ship ship,
      Ship_Request request,
      out Ship_Result result)
    {
      return this.CreateParametricData(ship, (Ship_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result)
    {
      result = (Ship_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) ship, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipService) this._Channel).GetActions(this._UserProfile, ship, parameters, request, out result) : this.AddMethod((Method) new ShipMethod(ship, ShipMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) ship, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Ship) null, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus GetActions(Ship ship)
    {
      return this.GetActions(ship, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus GetActions(
      Ship ship,
      Ship_Request request,
      out Ship_Result result)
    {
      return this.GetActions(ship, (Ship_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result)
    {
      result = (Ship_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) ship, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipService) this._Channel).GetDataPoints(this._UserProfile, ship, parameters, request, out result) : this.AddMethod((Method) new ShipMethod(ship, ShipMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) ship, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Ship) null, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus GetDataPoints(Ship ship)
    {
      return this.GetDataPoints(ship, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus GetDataPoints(
      Ship ship,
      Ship_Request request,
      out Ship_Result result)
    {
      return this.GetDataPoints(ship, (Ship_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result)
    {
      result = (Ship_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) ship, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipService) this._Channel).GetWIPMsgs(this._UserProfile, ship, parameters, request, out result) : this.AddMethod((Method) new ShipMethod(ship, ShipMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) ship, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Ship) null, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus GetWIPMsgs(Ship ship)
    {
      return this.GetWIPMsgs(ship, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Ship ship,
      Ship_Request request,
      out Ship_Result result)
    {
      return this.GetWIPMsgs(ship, (Ship_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result)
    {
      result = (Ship_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) ship, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipService) this._Channel).Load(this._UserProfile, ship, parameters, request, out result) : this.AddMethod((Method) new ShipMethod(ship, ShipMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) ship, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Ship) null, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus Load(Ship ship)
    {
      return this.Load(ship, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus Load(Ship ship, Ship_Request request, out Ship_Result result)
    {
      return this.Load(ship, (Ship_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Ship ship,
      Ship_LoadESigDetails_Parameters parameters,
      Ship_Request request,
      out Ship_Result result)
    {
      result = (Ship_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) ship, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipService) this._Channel).LoadESigDetails(this._UserProfile, ship, parameters, request, out result) : this.AddMethod((Method) new ShipMethod(ship, ShipMethods.LoadESigDetails, (Ship_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) ship, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Ship) null, (Ship_LoadESigDetails_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus LoadESigDetails(Ship ship)
    {
      return this.LoadESigDetails(ship, (Ship_LoadESigDetails_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus LoadESigDetails(
      Ship ship,
      Ship_Request request,
      out Ship_Result result)
    {
      return this.LoadESigDetails(ship, (Ship_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result)
    {
      result = (Ship_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) ship, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipService) this._Channel).ProcessComputation(this._UserProfile, ship, parameters, request, out result) : this.AddMethod((Method) new ShipMethod(ship, ShipMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) ship, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Ship) null, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus ProcessComputation(Ship ship)
    {
      return this.ProcessComputation(ship, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus ProcessComputation(
      Ship ship,
      Ship_Request request,
      out Ship_Result result)
    {
      return this.ProcessComputation(ship, (Ship_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Ship ship,
      Ship_Parameters parameters,
      Ship_Request request,
      out Ship_Result result)
    {
      result = (Ship_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) ship, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipService) this._Channel).ResolveParametricData(this._UserProfile, ship, parameters, request, out result) : this.AddMethod((Method) new ShipMethod(ship, ShipMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) ship, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Ship) null, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus ResolveParametricData(Ship ship)
    {
      return this.ResolveParametricData(ship, (Ship_Parameters) null, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus ResolveParametricData(
      Ship ship,
      Ship_Request request,
      out Ship_Result result)
    {
      return this.ResolveParametricData(ship, (Ship_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject ship,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Ship_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Ship) ship, (Ship_Parameters) parameters, (Ship_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject ship,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Ship_Result result1;
        ResultStatus actions = this.GetActions((Ship) ship, (Ship_Parameters) parameters, (Ship_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject ship,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Ship_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Ship) ship, (Ship_Parameters) parameters, (Ship_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject ship,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Ship_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Ship) ship, (Ship_LoadESigDetails_Parameters) parameters, (Ship_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject ship,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Ship_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Ship) ship, (Ship_Parameters) parameters, (Ship_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject ship,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Ship_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Ship) ship, (Ship_Parameters) parameters, (Ship_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject ship,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Ship_Result result1;
        ResultStatus resultStatus = this.Load((Ship) ship, (Ship_Parameters) parameters, (Ship_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject ship,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Ship_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Ship) ship, (Ship_Parameters) parameters, (Ship_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(Ship_Request request, out Ship_Result result)
    {
      result = (Ship_Result) null;
      try
      {
        ShipMethod[] methods = new ShipMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IShipService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Ship_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Ship_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Ship cdo,
      Ship_Request request,
      out Ship_Result result)
    {
      result = (Ship_Result) null;
      try
      {
        return ((IShipService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Ship_Result result1;
        ResultStatus environment = this.GetEnvironment((Ship) cdo, (Ship_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(Ship_Request request, out Ship_Result result)
    {
      return this.GetEnvironment((Ship) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Ship cdo,
      Ship_Request request,
      out Ship_Result result)
    {
      result = (Ship_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShipService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ShipMethod(cdo, ShipMethods.ExecuteTransaction, (Ship_Parameters) null));
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
        Ship_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Ship) cdo, (Ship_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Ship cdo)
    {
      return this.ExecuteTransaction(cdo, (Ship_Request) null, out Ship_Result _);
    }

    public ResultStatus ExecuteTransaction(Ship_Request request, out Ship_Result result)
    {
      return this.ExecuteTransaction((Ship) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Ship cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ShipMethod(cdo, ShipMethods.AddDataTransaction, (Ship_Parameters) null));
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
        return this.AddDataTransaction((Ship) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
