// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SerializeService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SerializeService : ContainerTxnBase
  {
    public SerializeService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISerializeService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) serialize, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeService) this._Channel).CreateParametricData(this._UserProfile, serialize, parameters, request, out result) : this.AddMethod((Method) new SerializeMethod(serialize, SerializeMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) serialize, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Serialize) null, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus CreateParametricData(Serialize serialize)
    {
      return this.CreateParametricData(serialize, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus CreateParametricData(
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.CreateParametricData(serialize, (Serialize_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) serialize, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeService) this._Channel).GetActions(this._UserProfile, serialize, parameters, request, out result) : this.AddMethod((Method) new SerializeMethod(serialize, SerializeMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) serialize, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Serialize) null, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus GetActions(Serialize serialize)
    {
      return this.GetActions(serialize, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus GetActions(
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.GetActions(serialize, (Serialize_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) serialize, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeService) this._Channel).GetDataPoints(this._UserProfile, serialize, parameters, request, out result) : this.AddMethod((Method) new SerializeMethod(serialize, SerializeMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) serialize, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Serialize) null, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus GetDataPoints(Serialize serialize)
    {
      return this.GetDataPoints(serialize, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus GetDataPoints(
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.GetDataPoints(serialize, (Serialize_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) serialize, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeService) this._Channel).GetWIPMsgs(this._UserProfile, serialize, parameters, request, out result) : this.AddMethod((Method) new SerializeMethod(serialize, SerializeMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) serialize, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Serialize) null, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus GetWIPMsgs(Serialize serialize)
    {
      return this.GetWIPMsgs(serialize, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.GetWIPMsgs(serialize, (Serialize_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) serialize, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeService) this._Channel).Load(this._UserProfile, serialize, parameters, request, out result) : this.AddMethod((Method) new SerializeMethod(serialize, SerializeMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) serialize, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Serialize) null, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus Load(Serialize serialize)
    {
      return this.Load(serialize, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus Load(
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.Load(serialize, (Serialize_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Serialize serialize,
      Serialize_LoadESigDetails_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) serialize, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeService) this._Channel).LoadESigDetails(this._UserProfile, serialize, parameters, request, out result) : this.AddMethod((Method) new SerializeMethod(serialize, SerializeMethods.LoadESigDetails, (Serialize_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) serialize, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Serialize) null, (Serialize_LoadESigDetails_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus LoadESigDetails(Serialize serialize)
    {
      return this.LoadESigDetails(serialize, (Serialize_LoadESigDetails_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus LoadESigDetails(
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.LoadESigDetails(serialize, (Serialize_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) serialize, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeService) this._Channel).ProcessComputation(this._UserProfile, serialize, parameters, request, out result) : this.AddMethod((Method) new SerializeMethod(serialize, SerializeMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) serialize, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Serialize) null, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus ProcessComputation(Serialize serialize)
    {
      return this.ProcessComputation(serialize, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus ProcessComputation(
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.ProcessComputation(serialize, (Serialize_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) serialize, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeService) this._Channel).ResolveParametricData(this._UserProfile, serialize, parameters, request, out result) : this.AddMethod((Method) new SerializeMethod(serialize, SerializeMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) serialize, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Serialize) null, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus ResolveParametricData(Serialize serialize)
    {
      return this.ResolveParametricData(serialize, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus ResolveParametricData(
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.ResolveParametricData(serialize, (Serialize_Parameters) null, request, out result);
    }

    public ResultStatus ValidateContainerNames(
      Serialize serialize,
      Serialize_Parameters parameters,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      this.OnBeforeCall(nameof (ValidateContainerNames), (DCObject) serialize, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeService) this._Channel).ValidateContainerNames(this._UserProfile, serialize, parameters, request, out result) : this.AddMethod((Method) new SerializeMethod(serialize, SerializeMethods.ValidateContainerNames, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateContainerNames), res, (DCObject) serialize, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateContainerNames()
    {
      return this.ValidateContainerNames((Serialize) null, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus ValidateContainerNames(Serialize serialize)
    {
      return this.ValidateContainerNames(serialize, (Serialize_Parameters) null, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus ValidateContainerNames(
      Serialize serialize,
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.ValidateContainerNames(serialize, (Serialize_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject serialize,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Serialize_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Serialize) serialize, (Serialize_Parameters) parameters, (Serialize_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject serialize,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Serialize_Result result1;
        ResultStatus actions = this.GetActions((Serialize) serialize, (Serialize_Parameters) parameters, (Serialize_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject serialize,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Serialize_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Serialize) serialize, (Serialize_Parameters) parameters, (Serialize_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject serialize,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Serialize_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Serialize) serialize, (Serialize_LoadESigDetails_Parameters) parameters, (Serialize_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject serialize,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Serialize_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Serialize) serialize, (Serialize_Parameters) parameters, (Serialize_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject serialize,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Serialize_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Serialize) serialize, (Serialize_Parameters) parameters, (Serialize_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject serialize,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Serialize_Result result1;
        ResultStatus resultStatus = this.Load((Serialize) serialize, (Serialize_Parameters) parameters, (Serialize_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject serialize,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Serialize_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Serialize) serialize, (Serialize_Parameters) parameters, (Serialize_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      try
      {
        SerializeMethod[] methods = new SerializeMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISerializeService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Serialize_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Serialize_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Serialize cdo,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      try
      {
        return ((ISerializeService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Serialize_Result result1;
        ResultStatus environment = this.GetEnvironment((Serialize) cdo, (Serialize_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.GetEnvironment((Serialize) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Serialize cdo,
      Serialize_Request request,
      out Serialize_Result result)
    {
      result = (Serialize_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISerializeService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SerializeMethod(cdo, SerializeMethods.ExecuteTransaction, (Serialize_Parameters) null));
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
        Serialize_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Serialize) cdo, (Serialize_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Serialize cdo)
    {
      return this.ExecuteTransaction(cdo, (Serialize_Request) null, out Serialize_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Serialize_Request request,
      out Serialize_Result result)
    {
      return this.ExecuteTransaction((Serialize) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Serialize cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SerializeMethod(cdo, SerializeMethods.AddDataTransaction, (Serialize_Parameters) null));
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
        return this.AddDataTransaction((Serialize) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
