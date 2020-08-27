// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.NCRCloseService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class NCRCloseService : NCRUpdateBase
  {
    public NCRCloseService(UserProfile userProfile)
    {
      this.Initialize(typeof (INCRCloseService), userProfile);
    }

    public ResultStatus CreateParametricData(
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) nCRClose, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).CreateParametricData(this._UserProfile, nCRClose, parameters, request, out result) : this.AddMethod((Method) new NCRCloseMethod(nCRClose, NCRCloseMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) nCRClose, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((NCRClose) null, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus CreateParametricData(NCRClose nCRClose)
    {
      return this.CreateParametricData(nCRClose, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus CreateParametricData(
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.CreateParametricData(nCRClose, (NCRClose_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) nCRClose, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).GetActions(this._UserProfile, nCRClose, parameters, request, out result) : this.AddMethod((Method) new NCRCloseMethod(nCRClose, NCRCloseMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) nCRClose, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((NCRClose) null, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus GetActions(NCRClose nCRClose)
    {
      return this.GetActions(nCRClose, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus GetActions(
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.GetActions(nCRClose, (NCRClose_Parameters) null, request, out result);
    }

    public ResultStatus GetAttributes(
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (GetAttributes), (DCObject) nCRClose, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).GetAttributes(this._UserProfile, nCRClose, parameters, request, out result) : this.AddMethod((Method) new NCRCloseMethod(nCRClose, NCRCloseMethods.GetAttributes, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetAttributes), res, (DCObject) nCRClose, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetAttributes()
    {
      return this.GetAttributes((NCRClose) null, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus GetAttributes(NCRClose nCRClose)
    {
      return this.GetAttributes(nCRClose, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus GetAttributes(
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.GetAttributes(nCRClose, (NCRClose_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) nCRClose, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).GetDataPoints(this._UserProfile, nCRClose, parameters, request, out result) : this.AddMethod((Method) new NCRCloseMethod(nCRClose, NCRCloseMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) nCRClose, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((NCRClose) null, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus GetDataPoints(NCRClose nCRClose)
    {
      return this.GetDataPoints(nCRClose, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus GetDataPoints(
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.GetDataPoints(nCRClose, (NCRClose_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) nCRClose, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).GetWIPMsgs(this._UserProfile, nCRClose, parameters, request, out result) : this.AddMethod((Method) new NCRCloseMethod(nCRClose, NCRCloseMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) nCRClose, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((NCRClose) null, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus GetWIPMsgs(NCRClose nCRClose)
    {
      return this.GetWIPMsgs(nCRClose, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus GetWIPMsgs(
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.GetWIPMsgs(nCRClose, (NCRClose_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) nCRClose, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).Load(this._UserProfile, nCRClose, parameters, request, out result) : this.AddMethod((Method) new NCRCloseMethod(nCRClose, NCRCloseMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) nCRClose, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((NCRClose) null, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus Load(NCRClose nCRClose)
    {
      return this.Load(nCRClose, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus Load(
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.Load(nCRClose, (NCRClose_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      NCRClose nCRClose,
      NCRClose_LoadESigDetails_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) nCRClose, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).LoadESigDetails(this._UserProfile, nCRClose, parameters, request, out result) : this.AddMethod((Method) new NCRCloseMethod(nCRClose, NCRCloseMethods.LoadESigDetails, (NCRClose_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) nCRClose, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((NCRClose) null, (NCRClose_LoadESigDetails_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus LoadESigDetails(NCRClose nCRClose)
    {
      return this.LoadESigDetails(nCRClose, (NCRClose_LoadESigDetails_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus LoadESigDetails(
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.LoadESigDetails(nCRClose, (NCRClose_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) nCRClose, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).ProcessComputation(this._UserProfile, nCRClose, parameters, request, out result) : this.AddMethod((Method) new NCRCloseMethod(nCRClose, NCRCloseMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) nCRClose, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((NCRClose) null, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus ProcessComputation(NCRClose nCRClose)
    {
      return this.ProcessComputation(nCRClose, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus ProcessComputation(
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.ProcessComputation(nCRClose, (NCRClose_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) nCRClose, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).ResolveParametricData(this._UserProfile, nCRClose, parameters, request, out result) : this.AddMethod((Method) new NCRCloseMethod(nCRClose, NCRCloseMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) nCRClose, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((NCRClose) null, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus ResolveParametricData(NCRClose nCRClose)
    {
      return this.ResolveParametricData(nCRClose, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus ResolveParametricData(
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.ResolveParametricData(nCRClose, (NCRClose_Parameters) null, request, out result);
    }

    public ResultStatus TerminateContainerCrossRefs(
      NCRClose nCRClose,
      NCRClose_Parameters parameters,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (TerminateContainerCrossRefs), (DCObject) nCRClose, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).TerminateContainerCrossRefs(this._UserProfile, nCRClose, parameters, request, out result) : this.AddMethod((Method) new NCRCloseMethod(nCRClose, NCRCloseMethods.TerminateContainerCrossRefs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (TerminateContainerCrossRefs), res, (DCObject) nCRClose, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus TerminateContainerCrossRefs()
    {
      return this.TerminateContainerCrossRefs((NCRClose) null, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus TerminateContainerCrossRefs(NCRClose nCRClose)
    {
      return this.TerminateContainerCrossRefs(nCRClose, (NCRClose_Parameters) null, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus TerminateContainerCrossRefs(
      NCRClose nCRClose,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.TerminateContainerCrossRefs(nCRClose, (NCRClose_Parameters) null, request, out result);
    }

    protected override ResultStatus OnGetAttributes(
      DCObject nCRClose,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRClose_Result result1;
        ResultStatus attributes = this.GetAttributes((NCRClose) nCRClose, (NCRClose_Parameters) parameters, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return attributes;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject nCRClose,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRClose_Result result1;
        ResultStatus parametricData = this.CreateParametricData((NCRClose) nCRClose, (NCRClose_Parameters) parameters, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject nCRClose,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRClose_Result result1;
        ResultStatus actions = this.GetActions((NCRClose) nCRClose, (NCRClose_Parameters) parameters, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject nCRClose,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRClose_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((NCRClose) nCRClose, (NCRClose_Parameters) parameters, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject nCRClose,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRClose_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((NCRClose) nCRClose, (NCRClose_LoadESigDetails_Parameters) parameters, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject nCRClose,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRClose_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((NCRClose) nCRClose, (NCRClose_Parameters) parameters, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject nCRClose,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRClose_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((NCRClose) nCRClose, (NCRClose_Parameters) parameters, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject nCRClose,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRClose_Result result1;
        ResultStatus resultStatus = this.Load((NCRClose) nCRClose, (NCRClose_Parameters) parameters, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject nCRClose,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        NCRClose_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((NCRClose) nCRClose, (NCRClose_Parameters) parameters, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      try
      {
        NCRCloseMethod[] methods = new NCRCloseMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((INCRCloseService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        NCRClose_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((NCRClose_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRClose cdo,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      try
      {
        return ((INCRCloseService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        NCRClose_Result result1;
        ResultStatus environment = this.GetEnvironment((NCRClose) cdo, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.GetEnvironment((NCRClose) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      NCRClose cdo,
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      result = (NCRClose_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((INCRCloseService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new NCRCloseMethod(cdo, NCRCloseMethods.ExecuteTransaction, (NCRClose_Parameters) null));
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
        NCRClose_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((NCRClose) cdo, (NCRClose_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(NCRClose cdo)
    {
      return this.ExecuteTransaction(cdo, (NCRClose_Request) null, out NCRClose_Result _);
    }

    public ResultStatus ExecuteTransaction(
      NCRClose_Request request,
      out NCRClose_Result result)
    {
      return this.ExecuteTransaction((NCRClose) null, request, out result);
    }

    public ResultStatus AddDataTransaction(NCRClose cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new NCRCloseMethod(cdo, NCRCloseMethods.AddDataTransaction, (NCRClose_Parameters) null));
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
        return this.AddDataTransaction((NCRClose) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
