// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CreateRegulatoryReportService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CreateRegulatoryReportService : RecordDecisionTreeBase
  {
    public CreateRegulatoryReportService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICreateRegulatoryReportService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateRegulatoryReportService) this._Channel).CreateParametricData(this._UserProfile, createRegulatoryReport, parameters, request, out result) : this.AddMethod((Method) new CreateRegulatoryReportMethod(createRegulatoryReport, CreateRegulatoryReportMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CreateRegulatoryReport) null, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus CreateParametricData(
      CreateRegulatoryReport createRegulatoryReport)
    {
      return this.CreateParametricData(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus CreateParametricData(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      return this.CreateParametricData(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateRegulatoryReportService) this._Channel).GetActions(this._UserProfile, createRegulatoryReport, parameters, request, out result) : this.AddMethod((Method) new CreateRegulatoryReportMethod(createRegulatoryReport, CreateRegulatoryReportMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CreateRegulatoryReport) null, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus GetActions(CreateRegulatoryReport createRegulatoryReport)
    {
      return this.GetActions(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus GetActions(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      return this.GetActions(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateRegulatoryReportService) this._Channel).GetDataPoints(this._UserProfile, createRegulatoryReport, parameters, request, out result) : this.AddMethod((Method) new CreateRegulatoryReportMethod(createRegulatoryReport, CreateRegulatoryReportMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CreateRegulatoryReport) null, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus GetDataPoints(CreateRegulatoryReport createRegulatoryReport)
    {
      return this.GetDataPoints(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus GetDataPoints(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      return this.GetDataPoints(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateRegulatoryReportService) this._Channel).GetWIPMsgs(this._UserProfile, createRegulatoryReport, parameters, request, out result) : this.AddMethod((Method) new CreateRegulatoryReportMethod(createRegulatoryReport, CreateRegulatoryReportMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CreateRegulatoryReport) null, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus GetWIPMsgs(CreateRegulatoryReport createRegulatoryReport)
    {
      return this.GetWIPMsgs(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      return this.GetWIPMsgs(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateRegulatoryReportService) this._Channel).Load(this._UserProfile, createRegulatoryReport, parameters, request, out result) : this.AddMethod((Method) new CreateRegulatoryReportMethod(createRegulatoryReport, CreateRegulatoryReportMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CreateRegulatoryReport) null, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus Load(CreateRegulatoryReport createRegulatoryReport)
    {
      return this.Load(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus Load(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      return this.Load(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateRegulatoryReportService) this._Channel).LoadESigDetails(this._UserProfile, createRegulatoryReport, parameters, request, out result) : this.AddMethod((Method) new CreateRegulatoryReportMethod(createRegulatoryReport, CreateRegulatoryReportMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CreateRegulatoryReport) null, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus LoadESigDetails(CreateRegulatoryReport createRegulatoryReport)
    {
      return this.LoadESigDetails(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus LoadESigDetails(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      return this.LoadESigDetails(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateRegulatoryReportService) this._Channel).ProcessComputation(this._UserProfile, createRegulatoryReport, parameters, request, out result) : this.AddMethod((Method) new CreateRegulatoryReportMethod(createRegulatoryReport, CreateRegulatoryReportMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CreateRegulatoryReport) null, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus ProcessComputation(CreateRegulatoryReport createRegulatoryReport)
    {
      return this.ProcessComputation(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus ProcessComputation(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      return this.ProcessComputation(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Parameters parameters,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateRegulatoryReportService) this._Channel).ResolveParametricData(this._UserProfile, createRegulatoryReport, parameters, request, out result) : this.AddMethod((Method) new CreateRegulatoryReportMethod(createRegulatoryReport, CreateRegulatoryReportMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) createRegulatoryReport, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CreateRegulatoryReport) null, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus ResolveParametricData(
      CreateRegulatoryReport createRegulatoryReport)
    {
      return this.ResolveParametricData(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus ResolveParametricData(
      CreateRegulatoryReport createRegulatoryReport,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      return this.ResolveParametricData(createRegulatoryReport, (CreateRegulatoryReport_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject createRegulatoryReport,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateRegulatoryReport_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CreateRegulatoryReport) createRegulatoryReport, (CreateRegulatoryReport_Parameters) parameters, (CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject createRegulatoryReport,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateRegulatoryReport_Result result1;
        ResultStatus actions = this.GetActions((CreateRegulatoryReport) createRegulatoryReport, (CreateRegulatoryReport_Parameters) parameters, (CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject createRegulatoryReport,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateRegulatoryReport_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CreateRegulatoryReport) createRegulatoryReport, (CreateRegulatoryReport_Parameters) parameters, (CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject createRegulatoryReport,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateRegulatoryReport_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CreateRegulatoryReport) createRegulatoryReport, (CreateRegulatoryReport_Parameters) parameters, (CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject createRegulatoryReport,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateRegulatoryReport_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CreateRegulatoryReport) createRegulatoryReport, (CreateRegulatoryReport_Parameters) parameters, (CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject createRegulatoryReport,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateRegulatoryReport_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CreateRegulatoryReport) createRegulatoryReport, (CreateRegulatoryReport_Parameters) parameters, (CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject createRegulatoryReport,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateRegulatoryReport_Result result1;
        ResultStatus resultStatus = this.Load((CreateRegulatoryReport) createRegulatoryReport, (CreateRegulatoryReport_Parameters) parameters, (CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject createRegulatoryReport,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CreateRegulatoryReport_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CreateRegulatoryReport) createRegulatoryReport, (CreateRegulatoryReport_Parameters) parameters, (CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      try
      {
        CreateRegulatoryReportMethod[] methods = new CreateRegulatoryReportMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICreateRegulatoryReportService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CreateRegulatoryReport_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CreateRegulatoryReport cdo,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      try
      {
        return ((ICreateRegulatoryReportService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CreateRegulatoryReport_Result result1;
        ResultStatus environment = this.GetEnvironment((CreateRegulatoryReport) cdo, (CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      return this.GetEnvironment((CreateRegulatoryReport) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CreateRegulatoryReport cdo,
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      result = (CreateRegulatoryReport_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICreateRegulatoryReportService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CreateRegulatoryReportMethod(cdo, CreateRegulatoryReportMethods.ExecuteTransaction, (CreateRegulatoryReport_Parameters) null));
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
        CreateRegulatoryReport_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CreateRegulatoryReport) cdo, (CreateRegulatoryReport_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CreateRegulatoryReport cdo)
    {
      return this.ExecuteTransaction(cdo, (CreateRegulatoryReport_Request) null, out CreateRegulatoryReport_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CreateRegulatoryReport_Request request,
      out CreateRegulatoryReport_Result result)
    {
      return this.ExecuteTransaction((CreateRegulatoryReport) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CreateRegulatoryReport cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CreateRegulatoryReportMethod(cdo, CreateRegulatoryReportMethods.AddDataTransaction, (CreateRegulatoryReport_Parameters) null));
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
        return this.AddDataTransaction((CreateRegulatoryReport) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
