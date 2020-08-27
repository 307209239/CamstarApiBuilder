// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.AssignChecklistService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class AssignChecklistService : GenericTxnBase
  {
    public AssignChecklistService(UserProfile userProfile)
    {
      this.Initialize(typeof (IAssignChecklistService), userProfile);
    }

    public ResultStatus CreateParametricData(
      AssignChecklist assignChecklist,
      AssignChecklist_Parameters parameters,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) assignChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).CreateParametricData(this._UserProfile, assignChecklist, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(assignChecklist, AssignChecklistMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) assignChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((AssignChecklist) null, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus CreateParametricData(AssignChecklist assignChecklist)
    {
      return this.CreateParametricData(assignChecklist, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus CreateParametricData(
      AssignChecklist assignChecklist,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.CreateParametricData(assignChecklist, (AssignChecklist_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      AssignChecklist assignChecklist,
      AssignChecklist_Parameters parameters,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) assignChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).GetActions(this._UserProfile, assignChecklist, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(assignChecklist, AssignChecklistMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) assignChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((AssignChecklist) null, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus GetActions(AssignChecklist assignChecklist)
    {
      return this.GetActions(assignChecklist, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus GetActions(
      AssignChecklist assignChecklist,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.GetActions(assignChecklist, (AssignChecklist_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      AssignChecklist assignChecklist,
      AssignChecklist_Parameters parameters,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) assignChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).GetDataPoints(this._UserProfile, assignChecklist, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(assignChecklist, AssignChecklistMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) assignChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((AssignChecklist) null, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus GetDataPoints(AssignChecklist assignChecklist)
    {
      return this.GetDataPoints(assignChecklist, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus GetDataPoints(
      AssignChecklist assignChecklist,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.GetDataPoints(assignChecklist, (AssignChecklist_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      AssignChecklist assignChecklist,
      AssignChecklist_Parameters parameters,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) assignChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).GetWIPMsgs(this._UserProfile, assignChecklist, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(assignChecklist, AssignChecklistMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) assignChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((AssignChecklist) null, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus GetWIPMsgs(AssignChecklist assignChecklist)
    {
      return this.GetWIPMsgs(assignChecklist, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus GetWIPMsgs(
      AssignChecklist assignChecklist,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.GetWIPMsgs(assignChecklist, (AssignChecklist_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      AssignChecklist assignChecklist,
      AssignChecklist_Parameters parameters,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) assignChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).Load(this._UserProfile, assignChecklist, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(assignChecklist, AssignChecklistMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) assignChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((AssignChecklist) null, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus Load(AssignChecklist assignChecklist)
    {
      return this.Load(assignChecklist, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus Load(
      AssignChecklist assignChecklist,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.Load(assignChecklist, (AssignChecklist_Parameters) null, request, out result);
    }

    public ResultStatus LoadChecklistTemplate(
      AssignChecklist assignChecklist,
      AssignChecklist_Parameters parameters,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (LoadChecklistTemplate), (DCObject) assignChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).LoadChecklistTemplate(this._UserProfile, assignChecklist, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(assignChecklist, AssignChecklistMethods.LoadChecklistTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadChecklistTemplate), res, (DCObject) assignChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadChecklistTemplate()
    {
      return this.LoadChecklistTemplate((AssignChecklist) null, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus LoadChecklistTemplate(AssignChecklist assignChecklist)
    {
      return this.LoadChecklistTemplate(assignChecklist, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus LoadChecklistTemplate(
      AssignChecklist assignChecklist,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.LoadChecklistTemplate(assignChecklist, (AssignChecklist_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      AssignChecklist assignChecklist,
      AssignChecklist_LoadESigDetails_Parameters parameters,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) assignChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).LoadESigDetails(this._UserProfile, assignChecklist, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(assignChecklist, AssignChecklistMethods.LoadESigDetails, (AssignChecklist_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) assignChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((AssignChecklist) null, (AssignChecklist_LoadESigDetails_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus LoadESigDetails(AssignChecklist assignChecklist)
    {
      return this.LoadESigDetails(assignChecklist, (AssignChecklist_LoadESigDetails_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus LoadESigDetails(
      AssignChecklist assignChecklist,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.LoadESigDetails(assignChecklist, (AssignChecklist_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      AssignChecklist assignChecklist,
      AssignChecklist_Parameters parameters,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) assignChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).ProcessComputation(this._UserProfile, assignChecklist, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(assignChecklist, AssignChecklistMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) assignChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((AssignChecklist) null, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus ProcessComputation(AssignChecklist assignChecklist)
    {
      return this.ProcessComputation(assignChecklist, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus ProcessComputation(
      AssignChecklist assignChecklist,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.ProcessComputation(assignChecklist, (AssignChecklist_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      AssignChecklist assignChecklist,
      AssignChecklist_Parameters parameters,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) assignChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).ResolveParametricData(this._UserProfile, assignChecklist, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(assignChecklist, AssignChecklistMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) assignChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((AssignChecklist) null, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus ResolveParametricData(AssignChecklist assignChecklist)
    {
      return this.ResolveParametricData(assignChecklist, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus ResolveParametricData(
      AssignChecklist assignChecklist,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.ResolveParametricData(assignChecklist, (AssignChecklist_Parameters) null, request, out result);
    }

    public ResultStatus SaveChecklist(
      AssignChecklist assignChecklist,
      AssignChecklist_Parameters parameters,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (SaveChecklist), (DCObject) assignChecklist, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).SaveChecklist(this._UserProfile, assignChecklist, parameters, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(assignChecklist, AssignChecklistMethods.SaveChecklist, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveChecklist), res, (DCObject) assignChecklist, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveChecklist()
    {
      return this.SaveChecklist((AssignChecklist) null, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus SaveChecklist(AssignChecklist assignChecklist)
    {
      return this.SaveChecklist(assignChecklist, (AssignChecklist_Parameters) null, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus SaveChecklist(
      AssignChecklist assignChecklist,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.SaveChecklist(assignChecklist, (AssignChecklist_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject assignChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklist_Result result1;
        ResultStatus parametricData = this.CreateParametricData((AssignChecklist) assignChecklist, (AssignChecklist_Parameters) parameters, (AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject assignChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklist_Result result1;
        ResultStatus actions = this.GetActions((AssignChecklist) assignChecklist, (AssignChecklist_Parameters) parameters, (AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject assignChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklist_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((AssignChecklist) assignChecklist, (AssignChecklist_Parameters) parameters, (AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject assignChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklist_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((AssignChecklist) assignChecklist, (AssignChecklist_LoadESigDetails_Parameters) parameters, (AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject assignChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklist_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((AssignChecklist) assignChecklist, (AssignChecklist_Parameters) parameters, (AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject assignChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklist_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((AssignChecklist) assignChecklist, (AssignChecklist_Parameters) parameters, (AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject assignChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklist_Result result1;
        ResultStatus resultStatus = this.Load((AssignChecklist) assignChecklist, (AssignChecklist_Parameters) parameters, (AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject assignChecklist,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        AssignChecklist_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((AssignChecklist) assignChecklist, (AssignChecklist_Parameters) parameters, (AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      try
      {
        AssignChecklistMethod[] methods = new AssignChecklistMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IAssignChecklistService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        AssignChecklist_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignChecklist cdo,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      try
      {
        return ((IAssignChecklistService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        AssignChecklist_Result result1;
        ResultStatus environment = this.GetEnvironment((AssignChecklist) cdo, (AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.GetEnvironment((AssignChecklist) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      AssignChecklist cdo,
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      result = (AssignChecklist_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IAssignChecklistService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new AssignChecklistMethod(cdo, AssignChecklistMethods.ExecuteTransaction, (AssignChecklist_Parameters) null));
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
        AssignChecklist_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((AssignChecklist) cdo, (AssignChecklist_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(AssignChecklist cdo)
    {
      return this.ExecuteTransaction(cdo, (AssignChecklist_Request) null, out AssignChecklist_Result _);
    }

    public ResultStatus ExecuteTransaction(
      AssignChecklist_Request request,
      out AssignChecklist_Result result)
    {
      return this.ExecuteTransaction((AssignChecklist) null, request, out result);
    }

    public ResultStatus AddDataTransaction(AssignChecklist cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new AssignChecklistMethod(cdo, AssignChecklistMethods.AddDataTransaction, (AssignChecklist_Parameters) null));
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
        return this.AddDataTransaction((AssignChecklist) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
