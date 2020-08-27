// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AssociateService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AssociateService : ContainerTxnBase
  {
    public AssociateService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAssociateService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) associate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssociateService) this._Channel).CreateParametricData(this._UserProfile, associate, parameters, request, out result) : this.AddMethod((Method) new AssociateMethod(associate, AssociateMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) associate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Associate) null, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus CreateParametricData(Associate associate)
    {
      return this.CreateParametricData(associate, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus CreateParametricData(
      Associate associate,
      Associate_Request request,
      out Associate_Result result)
    {
      return this.CreateParametricData(associate, (Associate_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) associate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssociateService) this._Channel).GetActions(this._UserProfile, associate, parameters, request, out result) : this.AddMethod((Method) new AssociateMethod(associate, AssociateMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) associate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Associate) null, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus GetActions(Associate associate)
    {
      return this.GetActions(associate, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus GetActions(
      Associate associate,
      Associate_Request request,
      out Associate_Result result)
    {
      return this.GetActions(associate, (Associate_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) associate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssociateService) this._Channel).GetDataPoints(this._UserProfile, associate, parameters, request, out result) : this.AddMethod((Method) new AssociateMethod(associate, AssociateMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) associate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Associate) null, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus GetDataPoints(Associate associate)
    {
      return this.GetDataPoints(associate, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus GetDataPoints(
      Associate associate,
      Associate_Request request,
      out Associate_Result result)
    {
      return this.GetDataPoints(associate, (Associate_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) associate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssociateService) this._Channel).GetWIPMsgs(this._UserProfile, associate, parameters, request, out result) : this.AddMethod((Method) new AssociateMethod(associate, AssociateMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) associate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Associate) null, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus GetWIPMsgs(Associate associate)
    {
      return this.GetWIPMsgs(associate, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Associate associate,
      Associate_Request request,
      out Associate_Result result)
    {
      return this.GetWIPMsgs(associate, (Associate_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) associate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssociateService) this._Channel).Load(this._UserProfile, associate, parameters, request, out result) : this.AddMethod((Method) new AssociateMethod(associate, AssociateMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) associate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Associate) null, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus Load(Associate associate)
    {
      return this.Load(associate, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus Load(
      Associate associate,
      Associate_Request request,
      out Associate_Result result)
    {
      return this.Load(associate, (Associate_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Associate associate,
      Associate_LoadESigDetails_Parameters parameters,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) associate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssociateService) this._Channel).LoadESigDetails(this._UserProfile, associate, parameters, request, out result) : this.AddMethod((Method) new AssociateMethod(associate, AssociateMethods.LoadESigDetails, (Associate_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) associate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Associate) null, (Associate_LoadESigDetails_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus LoadESigDetails(Associate associate)
    {
      return this.LoadESigDetails(associate, (Associate_LoadESigDetails_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus LoadESigDetails(
      Associate associate,
      Associate_Request request,
      out Associate_Result result)
    {
      return this.LoadESigDetails(associate, (Associate_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) associate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssociateService) this._Channel).ProcessComputation(this._UserProfile, associate, parameters, request, out result) : this.AddMethod((Method) new AssociateMethod(associate, AssociateMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) associate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Associate) null, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus ProcessComputation(Associate associate)
    {
      return this.ProcessComputation(associate, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus ProcessComputation(
      Associate associate,
      Associate_Request request,
      out Associate_Result result)
    {
      return this.ProcessComputation(associate, (Associate_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) associate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssociateService) this._Channel).ResolveParametricData(this._UserProfile, associate, parameters, request, out result) : this.AddMethod((Method) new AssociateMethod(associate, AssociateMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) associate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Associate) null, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus ResolveParametricData(Associate associate)
    {
      return this.ResolveParametricData(associate, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus ResolveParametricData(
      Associate associate,
      Associate_Request request,
      out Associate_Result result)
    {
      return this.ResolveParametricData(associate, (Associate_Parameters) null, request, out result);
    }

    public ResultStatus Validate_OneChildContainer(
      Associate associate,
      Associate_Parameters parameters,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      this.OnBeforeCall(nameof (Validate_OneChildContainer), (DCObject) associate, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssociateService) this._Channel).Validate_OneChildContainer(this._UserProfile, associate, parameters, request, out result) : this.AddMethod((Method) new AssociateMethod(associate, AssociateMethods.Validate_OneChildContainer, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Validate_OneChildContainer), res, (DCObject) associate, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Validate_OneChildContainer()
    {
      return this.Validate_OneChildContainer((Associate) null, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus Validate_OneChildContainer(Associate associate)
    {
      return this.Validate_OneChildContainer(associate, (Associate_Parameters) null, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus Validate_OneChildContainer(
      Associate associate,
      Associate_Request request,
      out Associate_Result result)
    {
      return this.Validate_OneChildContainer(associate, (Associate_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject associate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Associate_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Associate) associate, (Associate_Parameters) parameters, (Associate_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject associate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Associate_Result result1;
        ResultStatus actions = this.GetActions((Associate) associate, (Associate_Parameters) parameters, (Associate_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject associate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Associate_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Associate) associate, (Associate_Parameters) parameters, (Associate_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject associate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Associate_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Associate) associate, (Associate_LoadESigDetails_Parameters) parameters, (Associate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject associate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Associate_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Associate) associate, (Associate_Parameters) parameters, (Associate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject associate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Associate_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Associate) associate, (Associate_Parameters) parameters, (Associate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject associate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Associate_Result result1;
        ResultStatus resultStatus = this.Load((Associate) associate, (Associate_Parameters) parameters, (Associate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject associate,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Associate_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Associate) associate, (Associate_Parameters) parameters, (Associate_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      try
      {
        AssociateMethod[] methods = new AssociateMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAssociateService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Associate_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Associate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Associate cdo,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      try
      {
        return ((IAssociateService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Associate_Result result1;
        ResultStatus environment = this.GetEnvironment((Associate) cdo, (Associate_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Associate_Request request,
      out Associate_Result result)
    {
      return this.GetEnvironment((Associate) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Associate cdo,
      Associate_Request request,
      out Associate_Result result)
    {
      result = (Associate_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssociateService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AssociateMethod(cdo, AssociateMethods.ExecuteTransaction, (Associate_Parameters) null));
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
        Associate_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Associate) cdo, (Associate_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Associate cdo)
    {
      return this.ExecuteTransaction(cdo, (Associate_Request) null, out Associate_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Associate_Request request,
      out Associate_Result result)
    {
      return this.ExecuteTransaction((Associate) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Associate cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AssociateMethod(cdo, AssociateMethods.AddDataTransaction, (Associate_Parameters) null));
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
        return this.AddDataTransaction((Associate) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
