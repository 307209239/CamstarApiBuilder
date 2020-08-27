// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AssignmentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AssignmentService : ProcessObjectTxnBase
  {
    public AssignmentService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAssignmentService), userProfile);
    }

    public ResultStatus CreateParametricData(
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) assignment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignmentService) this._Channel).CreateParametricData(this._UserProfile, assignment, parameters, request, out result) : this.AddMethod((Method) new AssignmentMethod(assignment, AssignmentMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) assignment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((Assignment) null, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus CreateParametricData(Assignment assignment)
    {
      return this.CreateParametricData(assignment, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus CreateParametricData(
      Assignment assignment,
      Assignment_Request request,
      out Assignment_Result result)
    {
      return this.CreateParametricData(assignment, (Assignment_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) assignment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignmentService) this._Channel).GetActions(this._UserProfile, assignment, parameters, request, out result) : this.AddMethod((Method) new AssignmentMethod(assignment, AssignmentMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) assignment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((Assignment) null, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus GetActions(Assignment assignment)
    {
      return this.GetActions(assignment, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus GetActions(
      Assignment assignment,
      Assignment_Request request,
      out Assignment_Result result)
    {
      return this.GetActions(assignment, (Assignment_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) assignment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignmentService) this._Channel).GetDataPoints(this._UserProfile, assignment, parameters, request, out result) : this.AddMethod((Method) new AssignmentMethod(assignment, AssignmentMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) assignment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((Assignment) null, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus GetDataPoints(Assignment assignment)
    {
      return this.GetDataPoints(assignment, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus GetDataPoints(
      Assignment assignment,
      Assignment_Request request,
      out Assignment_Result result)
    {
      return this.GetDataPoints(assignment, (Assignment_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) assignment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignmentService) this._Channel).GetWIPMsgs(this._UserProfile, assignment, parameters, request, out result) : this.AddMethod((Method) new AssignmentMethod(assignment, AssignmentMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) assignment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((Assignment) null, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus GetWIPMsgs(Assignment assignment)
    {
      return this.GetWIPMsgs(assignment, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus GetWIPMsgs(
      Assignment assignment,
      Assignment_Request request,
      out Assignment_Result result)
    {
      return this.GetWIPMsgs(assignment, (Assignment_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) assignment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignmentService) this._Channel).Load(this._UserProfile, assignment, parameters, request, out result) : this.AddMethod((Method) new AssignmentMethod(assignment, AssignmentMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) assignment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((Assignment) null, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus Load(Assignment assignment)
    {
      return this.Load(assignment, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus Load(
      Assignment assignment,
      Assignment_Request request,
      out Assignment_Result result)
    {
      return this.Load(assignment, (Assignment_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) assignment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignmentService) this._Channel).LoadESigDetails(this._UserProfile, assignment, parameters, request, out result) : this.AddMethod((Method) new AssignmentMethod(assignment, AssignmentMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) assignment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((Assignment) null, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus LoadESigDetails(Assignment assignment)
    {
      return this.LoadESigDetails(assignment, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus LoadESigDetails(
      Assignment assignment,
      Assignment_Request request,
      out Assignment_Result result)
    {
      return this.LoadESigDetails(assignment, (Assignment_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) assignment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignmentService) this._Channel).ProcessComputation(this._UserProfile, assignment, parameters, request, out result) : this.AddMethod((Method) new AssignmentMethod(assignment, AssignmentMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) assignment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((Assignment) null, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus ProcessComputation(Assignment assignment)
    {
      return this.ProcessComputation(assignment, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus ProcessComputation(
      Assignment assignment,
      Assignment_Request request,
      out Assignment_Result result)
    {
      return this.ProcessComputation(assignment, (Assignment_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      Assignment assignment,
      Assignment_Parameters parameters,
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) assignment, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignmentService) this._Channel).ResolveParametricData(this._UserProfile, assignment, parameters, request, out result) : this.AddMethod((Method) new AssignmentMethod(assignment, AssignmentMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) assignment, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((Assignment) null, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus ResolveParametricData(Assignment assignment)
    {
      return this.ResolveParametricData(assignment, (Assignment_Parameters) null, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus ResolveParametricData(
      Assignment assignment,
      Assignment_Request request,
      out Assignment_Result result)
    {
      return this.ResolveParametricData(assignment, (Assignment_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject assignment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Assignment_Result result1;
        ResultStatus parametricData = this.CreateParametricData((Assignment) assignment, (Assignment_Parameters) parameters, (Assignment_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject assignment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Assignment_Result result1;
        ResultStatus actions = this.GetActions((Assignment) assignment, (Assignment_Parameters) parameters, (Assignment_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject assignment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Assignment_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((Assignment) assignment, (Assignment_Parameters) parameters, (Assignment_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject assignment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Assignment_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((Assignment) assignment, (Assignment_Parameters) parameters, (Assignment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject assignment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Assignment_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((Assignment) assignment, (Assignment_Parameters) parameters, (Assignment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject assignment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Assignment_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((Assignment) assignment, (Assignment_Parameters) parameters, (Assignment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject assignment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Assignment_Result result1;
        ResultStatus resultStatus = this.Load((Assignment) assignment, (Assignment_Parameters) parameters, (Assignment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject assignment,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        Assignment_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((Assignment) assignment, (Assignment_Parameters) parameters, (Assignment_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      try
      {
        AssignmentMethod[] methods = new AssignmentMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAssignmentService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        Assignment_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((Assignment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Assignment cdo,
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      try
      {
        return ((IAssignmentService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        Assignment_Result result1;
        ResultStatus environment = this.GetEnvironment((Assignment) cdo, (Assignment_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      Assignment_Request request,
      out Assignment_Result result)
    {
      return this.GetEnvironment((Assignment) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      Assignment cdo,
      Assignment_Request request,
      out Assignment_Result result)
    {
      result = (Assignment_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignmentService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AssignmentMethod(cdo, AssignmentMethods.ExecuteTransaction, (Assignment_Parameters) null));
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
        Assignment_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((Assignment) cdo, (Assignment_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(Assignment cdo)
    {
      return this.ExecuteTransaction(cdo, (Assignment_Request) null, out Assignment_Result _);
    }

    public ResultStatus ExecuteTransaction(
      Assignment_Request request,
      out Assignment_Result result)
    {
      return this.ExecuteTransaction((Assignment) null, request, out result);
    }

    public ResultStatus AddDataTransaction(Assignment cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AssignmentMethod(cdo, AssignmentMethods.AddDataTransaction, (Assignment_Parameters) null));
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
        return this.AddDataTransaction((Assignment) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
