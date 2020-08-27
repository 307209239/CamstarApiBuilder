// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SerializeSecondaryQtyService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SerializeSecondaryQtyService : SerializeBase
  {
    public SerializeSecondaryQtyService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISerializeSecondaryQtyService), userProfile);
    }

    public ResultStatus CreateParametricData(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeSecondaryQtyService) this._Channel).CreateParametricData(this._UserProfile, serializeSecondaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializeSecondaryQtyMethod(serializeSecondaryQty, SerializeSecondaryQtyMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((SerializeSecondaryQty) null, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus CreateParametricData(SerializeSecondaryQty serializeSecondaryQty)
    {
      return this.CreateParametricData(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus CreateParametricData(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      return this.CreateParametricData(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeSecondaryQtyService) this._Channel).GetActions(this._UserProfile, serializeSecondaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializeSecondaryQtyMethod(serializeSecondaryQty, SerializeSecondaryQtyMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((SerializeSecondaryQty) null, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus GetActions(SerializeSecondaryQty serializeSecondaryQty)
    {
      return this.GetActions(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus GetActions(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      return this.GetActions(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeSecondaryQtyService) this._Channel).GetDataPoints(this._UserProfile, serializeSecondaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializeSecondaryQtyMethod(serializeSecondaryQty, SerializeSecondaryQtyMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((SerializeSecondaryQty) null, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus GetDataPoints(SerializeSecondaryQty serializeSecondaryQty)
    {
      return this.GetDataPoints(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus GetDataPoints(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      return this.GetDataPoints(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeSecondaryQtyService) this._Channel).GetWIPMsgs(this._UserProfile, serializeSecondaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializeSecondaryQtyMethod(serializeSecondaryQty, SerializeSecondaryQtyMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SerializeSecondaryQty) null, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus GetWIPMsgs(SerializeSecondaryQty serializeSecondaryQty)
    {
      return this.GetWIPMsgs(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      return this.GetWIPMsgs(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeSecondaryQtyService) this._Channel).Load(this._UserProfile, serializeSecondaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializeSecondaryQtyMethod(serializeSecondaryQty, SerializeSecondaryQtyMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SerializeSecondaryQty) null, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus Load(SerializeSecondaryQty serializeSecondaryQty)
    {
      return this.Load(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus Load(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      return this.Load(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_LoadESigDetails_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeSecondaryQtyService) this._Channel).LoadESigDetails(this._UserProfile, serializeSecondaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializeSecondaryQtyMethod(serializeSecondaryQty, SerializeSecondaryQtyMethods.LoadESigDetails, (SerializeSecondaryQty_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SerializeSecondaryQty) null, (SerializeSecondaryQty_LoadESigDetails_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus LoadESigDetails(SerializeSecondaryQty serializeSecondaryQty)
    {
      return this.LoadESigDetails(serializeSecondaryQty, (SerializeSecondaryQty_LoadESigDetails_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus LoadESigDetails(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      return this.LoadESigDetails(serializeSecondaryQty, (SerializeSecondaryQty_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeSecondaryQtyService) this._Channel).ProcessComputation(this._UserProfile, serializeSecondaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializeSecondaryQtyMethod(serializeSecondaryQty, SerializeSecondaryQtyMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((SerializeSecondaryQty) null, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus ProcessComputation(SerializeSecondaryQty serializeSecondaryQty)
    {
      return this.ProcessComputation(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus ProcessComputation(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      return this.ProcessComputation(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Parameters parameters,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeSecondaryQtyService) this._Channel).ResolveParametricData(this._UserProfile, serializeSecondaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializeSecondaryQtyMethod(serializeSecondaryQty, SerializeSecondaryQtyMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) serializeSecondaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((SerializeSecondaryQty) null, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus ResolveParametricData(
      SerializeSecondaryQty serializeSecondaryQty)
    {
      return this.ResolveParametricData(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus ResolveParametricData(
      SerializeSecondaryQty serializeSecondaryQty,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      return this.ResolveParametricData(serializeSecondaryQty, (SerializeSecondaryQty_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject serializeSecondaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializeSecondaryQty_Result result1;
        ResultStatus parametricData = this.CreateParametricData((SerializeSecondaryQty) serializeSecondaryQty, (SerializeSecondaryQty_Parameters) parameters, (SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject serializeSecondaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializeSecondaryQty_Result result1;
        ResultStatus actions = this.GetActions((SerializeSecondaryQty) serializeSecondaryQty, (SerializeSecondaryQty_Parameters) parameters, (SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject serializeSecondaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializeSecondaryQty_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((SerializeSecondaryQty) serializeSecondaryQty, (SerializeSecondaryQty_Parameters) parameters, (SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject serializeSecondaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializeSecondaryQty_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SerializeSecondaryQty) serializeSecondaryQty, (SerializeSecondaryQty_LoadESigDetails_Parameters) parameters, (SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject serializeSecondaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializeSecondaryQty_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((SerializeSecondaryQty) serializeSecondaryQty, (SerializeSecondaryQty_Parameters) parameters, (SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject serializeSecondaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializeSecondaryQty_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((SerializeSecondaryQty) serializeSecondaryQty, (SerializeSecondaryQty_Parameters) parameters, (SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject serializeSecondaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializeSecondaryQty_Result result1;
        ResultStatus resultStatus = this.Load((SerializeSecondaryQty) serializeSecondaryQty, (SerializeSecondaryQty_Parameters) parameters, (SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject serializeSecondaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializeSecondaryQty_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SerializeSecondaryQty) serializeSecondaryQty, (SerializeSecondaryQty_Parameters) parameters, (SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      try
      {
        SerializeSecondaryQtyMethod[] methods = new SerializeSecondaryQtyMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISerializeSecondaryQtyService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SerializeSecondaryQty_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SerializeSecondaryQty cdo,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      try
      {
        return ((ISerializeSecondaryQtyService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SerializeSecondaryQty_Result result1;
        ResultStatus environment = this.GetEnvironment((SerializeSecondaryQty) cdo, (SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      return this.GetEnvironment((SerializeSecondaryQty) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SerializeSecondaryQty cdo,
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      result = (SerializeSecondaryQty_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeSecondaryQtyService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SerializeSecondaryQtyMethod(cdo, SerializeSecondaryQtyMethods.ExecuteTransaction, (SerializeSecondaryQty_Parameters) null));
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
        SerializeSecondaryQty_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SerializeSecondaryQty) cdo, (SerializeSecondaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SerializeSecondaryQty cdo)
    {
      return this.ExecuteTransaction(cdo, (SerializeSecondaryQty_Request) null, out SerializeSecondaryQty_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SerializeSecondaryQty_Request request,
      out SerializeSecondaryQty_Result result)
    {
      return this.ExecuteTransaction((SerializeSecondaryQty) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SerializeSecondaryQty cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SerializeSecondaryQtyMethod(cdo, SerializeSecondaryQtyMethods.AddDataTransaction, (SerializeSecondaryQty_Parameters) null));
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
        return this.AddDataTransaction((SerializeSecondaryQty) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
