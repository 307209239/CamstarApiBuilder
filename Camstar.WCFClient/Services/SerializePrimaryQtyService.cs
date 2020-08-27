// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SerializePrimaryQtyService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SerializePrimaryQtyService : SerializeBase
  {
    public SerializePrimaryQtyService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISerializePrimaryQtyService), userProfile);
    }

    public ResultStatus CreateParametricData(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializePrimaryQtyService) this._Channel).CreateParametricData(this._UserProfile, serializePrimaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializePrimaryQtyMethod(serializePrimaryQty, SerializePrimaryQtyMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((SerializePrimaryQty) null, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus CreateParametricData(SerializePrimaryQty serializePrimaryQty)
    {
      return this.CreateParametricData(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus CreateParametricData(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      return this.CreateParametricData(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializePrimaryQtyService) this._Channel).GetActions(this._UserProfile, serializePrimaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializePrimaryQtyMethod(serializePrimaryQty, SerializePrimaryQtyMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((SerializePrimaryQty) null, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus GetActions(SerializePrimaryQty serializePrimaryQty)
    {
      return this.GetActions(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus GetActions(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      return this.GetActions(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializePrimaryQtyService) this._Channel).GetDataPoints(this._UserProfile, serializePrimaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializePrimaryQtyMethod(serializePrimaryQty, SerializePrimaryQtyMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((SerializePrimaryQty) null, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus GetDataPoints(SerializePrimaryQty serializePrimaryQty)
    {
      return this.GetDataPoints(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus GetDataPoints(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      return this.GetDataPoints(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializePrimaryQtyService) this._Channel).GetWIPMsgs(this._UserProfile, serializePrimaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializePrimaryQtyMethod(serializePrimaryQty, SerializePrimaryQtyMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SerializePrimaryQty) null, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus GetWIPMsgs(SerializePrimaryQty serializePrimaryQty)
    {
      return this.GetWIPMsgs(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      return this.GetWIPMsgs(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializePrimaryQtyService) this._Channel).Load(this._UserProfile, serializePrimaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializePrimaryQtyMethod(serializePrimaryQty, SerializePrimaryQtyMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SerializePrimaryQty) null, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus Load(SerializePrimaryQty serializePrimaryQty)
    {
      return this.Load(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus Load(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      return this.Load(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_LoadESigDetails_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializePrimaryQtyService) this._Channel).LoadESigDetails(this._UserProfile, serializePrimaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializePrimaryQtyMethod(serializePrimaryQty, SerializePrimaryQtyMethods.LoadESigDetails, (SerializePrimaryQty_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SerializePrimaryQty) null, (SerializePrimaryQty_LoadESigDetails_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus LoadESigDetails(SerializePrimaryQty serializePrimaryQty)
    {
      return this.LoadESigDetails(serializePrimaryQty, (SerializePrimaryQty_LoadESigDetails_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus LoadESigDetails(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      return this.LoadESigDetails(serializePrimaryQty, (SerializePrimaryQty_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializePrimaryQtyService) this._Channel).ProcessComputation(this._UserProfile, serializePrimaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializePrimaryQtyMethod(serializePrimaryQty, SerializePrimaryQtyMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((SerializePrimaryQty) null, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus ProcessComputation(SerializePrimaryQty serializePrimaryQty)
    {
      return this.ProcessComputation(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus ProcessComputation(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      return this.ProcessComputation(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Parameters parameters,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializePrimaryQtyService) this._Channel).ResolveParametricData(this._UserProfile, serializePrimaryQty, parameters, request, out result) : this.AddMethod((Method) new SerializePrimaryQtyMethod(serializePrimaryQty, SerializePrimaryQtyMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) serializePrimaryQty, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((SerializePrimaryQty) null, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus ResolveParametricData(SerializePrimaryQty serializePrimaryQty)
    {
      return this.ResolveParametricData(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus ResolveParametricData(
      SerializePrimaryQty serializePrimaryQty,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      return this.ResolveParametricData(serializePrimaryQty, (SerializePrimaryQty_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject serializePrimaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializePrimaryQty_Result result1;
        ResultStatus parametricData = this.CreateParametricData((SerializePrimaryQty) serializePrimaryQty, (SerializePrimaryQty_Parameters) parameters, (SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject serializePrimaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializePrimaryQty_Result result1;
        ResultStatus actions = this.GetActions((SerializePrimaryQty) serializePrimaryQty, (SerializePrimaryQty_Parameters) parameters, (SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject serializePrimaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializePrimaryQty_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((SerializePrimaryQty) serializePrimaryQty, (SerializePrimaryQty_Parameters) parameters, (SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject serializePrimaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializePrimaryQty_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SerializePrimaryQty) serializePrimaryQty, (SerializePrimaryQty_LoadESigDetails_Parameters) parameters, (SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject serializePrimaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializePrimaryQty_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((SerializePrimaryQty) serializePrimaryQty, (SerializePrimaryQty_Parameters) parameters, (SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject serializePrimaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializePrimaryQty_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((SerializePrimaryQty) serializePrimaryQty, (SerializePrimaryQty_Parameters) parameters, (SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject serializePrimaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializePrimaryQty_Result result1;
        ResultStatus resultStatus = this.Load((SerializePrimaryQty) serializePrimaryQty, (SerializePrimaryQty_Parameters) parameters, (SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject serializePrimaryQty,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SerializePrimaryQty_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SerializePrimaryQty) serializePrimaryQty, (SerializePrimaryQty_Parameters) parameters, (SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      try
      {
        SerializePrimaryQtyMethod[] methods = new SerializePrimaryQtyMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISerializePrimaryQtyService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SerializePrimaryQty_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SerializePrimaryQty cdo,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      try
      {
        return ((ISerializePrimaryQtyService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SerializePrimaryQty_Result result1;
        ResultStatus environment = this.GetEnvironment((SerializePrimaryQty) cdo, (SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      return this.GetEnvironment((SerializePrimaryQty) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SerializePrimaryQty cdo,
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      result = (SerializePrimaryQty_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializePrimaryQtyService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SerializePrimaryQtyMethod(cdo, SerializePrimaryQtyMethods.ExecuteTransaction, (SerializePrimaryQty_Parameters) null));
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
        SerializePrimaryQty_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SerializePrimaryQty) cdo, (SerializePrimaryQty_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SerializePrimaryQty cdo)
    {
      return this.ExecuteTransaction(cdo, (SerializePrimaryQty_Request) null, out SerializePrimaryQty_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SerializePrimaryQty_Request request,
      out SerializePrimaryQty_Result result)
    {
      return this.ExecuteTransaction((SerializePrimaryQty) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SerializePrimaryQty cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SerializePrimaryQtyMethod(cdo, SerializePrimaryQtyMethods.AddDataTransaction, (SerializePrimaryQty_Parameters) null));
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
        return this.AddDataTransaction((SerializePrimaryQty) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
