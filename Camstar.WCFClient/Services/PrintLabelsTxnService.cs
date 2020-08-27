// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintLabelsTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PrintLabelsTxnService : ShopFloorBase
  {
    public PrintLabelsTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPrintLabelsTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).CreateParametricData(this._UserProfile, printLabelsTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(printLabelsTxn, PrintLabelsTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((PrintLabelsTxn) null, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus CreateParametricData(PrintLabelsTxn printLabelsTxn)
    {
      return this.CreateParametricData(printLabelsTxn, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.CreateParametricData(printLabelsTxn, (PrintLabelsTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).GetActions(this._UserProfile, printLabelsTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(printLabelsTxn, PrintLabelsTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((PrintLabelsTxn) null, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus GetActions(PrintLabelsTxn printLabelsTxn)
    {
      return this.GetActions(printLabelsTxn, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus GetActions(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.GetActions(printLabelsTxn, (PrintLabelsTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).GetDataPoints(this._UserProfile, printLabelsTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(printLabelsTxn, PrintLabelsTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((PrintLabelsTxn) null, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus GetDataPoints(PrintLabelsTxn printLabelsTxn)
    {
      return this.GetDataPoints(printLabelsTxn, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.GetDataPoints(printLabelsTxn, (PrintLabelsTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).GetWIPMsgs(this._UserProfile, printLabelsTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(printLabelsTxn, PrintLabelsTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PrintLabelsTxn) null, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(PrintLabelsTxn printLabelsTxn)
    {
      return this.GetWIPMsgs(printLabelsTxn, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.GetWIPMsgs(printLabelsTxn, (PrintLabelsTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).Load(this._UserProfile, printLabelsTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(printLabelsTxn, PrintLabelsTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PrintLabelsTxn) null, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus Load(PrintLabelsTxn printLabelsTxn)
    {
      return this.Load(printLabelsTxn, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus Load(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.Load(printLabelsTxn, (PrintLabelsTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_LoadESigDetails_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).LoadESigDetails(this._UserProfile, printLabelsTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(printLabelsTxn, PrintLabelsTxnMethods.LoadESigDetails, (PrintLabelsTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PrintLabelsTxn) null, (PrintLabelsTxn_LoadESigDetails_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus LoadESigDetails(PrintLabelsTxn printLabelsTxn)
    {
      return this.LoadESigDetails(printLabelsTxn, (PrintLabelsTxn_LoadESigDetails_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.LoadESigDetails(printLabelsTxn, (PrintLabelsTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_PopulateService_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (PopulateService), (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).PopulateService(this._UserProfile, printLabelsTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(printLabelsTxn, PrintLabelsTxnMethods.PopulateService, (PrintLabelsTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService), res, (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService()
    {
      return this.PopulateService((PrintLabelsTxn) null, (PrintLabelsTxn_PopulateService_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus PopulateService(PrintLabelsTxn printLabelsTxn)
    {
      return this.PopulateService(printLabelsTxn, (PrintLabelsTxn_PopulateService_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus PopulateService(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.PopulateService(printLabelsTxn, (PrintLabelsTxn_PopulateService_Parameters) null, request, out result);
    }

    public ResultStatus PopulateService_User(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (PopulateService_User), (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).PopulateService_User(this._UserProfile, printLabelsTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(printLabelsTxn, PrintLabelsTxnMethods.PopulateService_User, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (PopulateService_User), res, (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus PopulateService_User()
    {
      return this.PopulateService_User((PrintLabelsTxn) null, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus PopulateService_User(PrintLabelsTxn printLabelsTxn)
    {
      return this.PopulateService_User(printLabelsTxn, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus PopulateService_User(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.PopulateService_User(printLabelsTxn, (PrintLabelsTxn_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).ProcessComputation(this._UserProfile, printLabelsTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(printLabelsTxn, PrintLabelsTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((PrintLabelsTxn) null, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus ProcessComputation(PrintLabelsTxn printLabelsTxn)
    {
      return this.ProcessComputation(printLabelsTxn, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.ProcessComputation(printLabelsTxn, (PrintLabelsTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Parameters parameters,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).ResolveParametricData(this._UserProfile, printLabelsTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(printLabelsTxn, PrintLabelsTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) printLabelsTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((PrintLabelsTxn) null, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus ResolveParametricData(PrintLabelsTxn printLabelsTxn)
    {
      return this.ResolveParametricData(printLabelsTxn, (PrintLabelsTxn_Parameters) null, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      PrintLabelsTxn printLabelsTxn,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.ResolveParametricData(printLabelsTxn, (PrintLabelsTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject printLabelsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelsTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((PrintLabelsTxn) printLabelsTxn, (PrintLabelsTxn_Parameters) parameters, (PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject printLabelsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelsTxn_Result result1;
        ResultStatus actions = this.GetActions((PrintLabelsTxn) printLabelsTxn, (PrintLabelsTxn_Parameters) parameters, (PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject printLabelsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelsTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((PrintLabelsTxn) printLabelsTxn, (PrintLabelsTxn_Parameters) parameters, (PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject printLabelsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelsTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PrintLabelsTxn) printLabelsTxn, (PrintLabelsTxn_LoadESigDetails_Parameters) parameters, (PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject printLabelsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelsTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((PrintLabelsTxn) printLabelsTxn, (PrintLabelsTxn_Parameters) parameters, (PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject printLabelsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelsTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((PrintLabelsTxn) printLabelsTxn, (PrintLabelsTxn_Parameters) parameters, (PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject printLabelsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelsTxn_Result result1;
        ResultStatus resultStatus = this.Load((PrintLabelsTxn) printLabelsTxn, (PrintLabelsTxn_Parameters) parameters, (PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject printLabelsTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelsTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PrintLabelsTxn) printLabelsTxn, (PrintLabelsTxn_Parameters) parameters, (PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      try
      {
        PrintLabelsTxnMethod[] methods = new PrintLabelsTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPrintLabelsTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PrintLabelsTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintLabelsTxn cdo,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      try
      {
        return ((IPrintLabelsTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PrintLabelsTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((PrintLabelsTxn) cdo, (PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.GetEnvironment((PrintLabelsTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PrintLabelsTxn cdo,
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      result = (PrintLabelsTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelsTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PrintLabelsTxnMethod(cdo, PrintLabelsTxnMethods.ExecuteTransaction, (PrintLabelsTxn_Parameters) null));
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
        PrintLabelsTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PrintLabelsTxn) cdo, (PrintLabelsTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PrintLabelsTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (PrintLabelsTxn_Request) null, out PrintLabelsTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PrintLabelsTxn_Request request,
      out PrintLabelsTxn_Result result)
    {
      return this.ExecuteTransaction((PrintLabelsTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PrintLabelsTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PrintLabelsTxnMethod(cdo, PrintLabelsTxnMethods.AddDataTransaction, (PrintLabelsTxn_Parameters) null));
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
        return this.AddDataTransaction((PrintLabelsTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
