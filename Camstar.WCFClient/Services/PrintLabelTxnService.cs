// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintLabelTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PrintLabelTxnService : ShopFloorBase
  {
    public PrintLabelTxnService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPrintLabelTxnService), userProfile);
    }

    public ResultStatus CreateParametricData(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) printLabelTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelTxnService) this._Channel).CreateParametricData(this._UserProfile, printLabelTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelTxnMethod(printLabelTxn, PrintLabelTxnMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) printLabelTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((PrintLabelTxn) null, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus CreateParametricData(PrintLabelTxn printLabelTxn)
    {
      return this.CreateParametricData(printLabelTxn, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus CreateParametricData(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      return this.CreateParametricData(printLabelTxn, (PrintLabelTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) printLabelTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelTxnService) this._Channel).GetActions(this._UserProfile, printLabelTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelTxnMethod(printLabelTxn, PrintLabelTxnMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) printLabelTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((PrintLabelTxn) null, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus GetActions(PrintLabelTxn printLabelTxn)
    {
      return this.GetActions(printLabelTxn, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus GetActions(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      return this.GetActions(printLabelTxn, (PrintLabelTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) printLabelTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelTxnService) this._Channel).GetDataPoints(this._UserProfile, printLabelTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelTxnMethod(printLabelTxn, PrintLabelTxnMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) printLabelTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((PrintLabelTxn) null, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus GetDataPoints(PrintLabelTxn printLabelTxn)
    {
      return this.GetDataPoints(printLabelTxn, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus GetDataPoints(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      return this.GetDataPoints(printLabelTxn, (PrintLabelTxn_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) printLabelTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelTxnService) this._Channel).GetWIPMsgs(this._UserProfile, printLabelTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelTxnMethod(printLabelTxn, PrintLabelTxnMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) printLabelTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PrintLabelTxn) null, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(PrintLabelTxn printLabelTxn)
    {
      return this.GetWIPMsgs(printLabelTxn, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      return this.GetWIPMsgs(printLabelTxn, (PrintLabelTxn_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) printLabelTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelTxnService) this._Channel).Load(this._UserProfile, printLabelTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelTxnMethod(printLabelTxn, PrintLabelTxnMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) printLabelTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PrintLabelTxn) null, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus Load(PrintLabelTxn printLabelTxn)
    {
      return this.Load(printLabelTxn, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus Load(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      return this.Load(printLabelTxn, (PrintLabelTxn_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_LoadESigDetails_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) printLabelTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelTxnService) this._Channel).LoadESigDetails(this._UserProfile, printLabelTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelTxnMethod(printLabelTxn, PrintLabelTxnMethods.LoadESigDetails, (PrintLabelTxn_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) printLabelTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PrintLabelTxn) null, (PrintLabelTxn_LoadESigDetails_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus LoadESigDetails(PrintLabelTxn printLabelTxn)
    {
      return this.LoadESigDetails(printLabelTxn, (PrintLabelTxn_LoadESigDetails_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus LoadESigDetails(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      return this.LoadESigDetails(printLabelTxn, (PrintLabelTxn_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) printLabelTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelTxnService) this._Channel).ProcessComputation(this._UserProfile, printLabelTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelTxnMethod(printLabelTxn, PrintLabelTxnMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) printLabelTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((PrintLabelTxn) null, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus ProcessComputation(PrintLabelTxn printLabelTxn)
    {
      return this.ProcessComputation(printLabelTxn, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus ProcessComputation(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      return this.ProcessComputation(printLabelTxn, (PrintLabelTxn_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Parameters parameters,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) printLabelTxn, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelTxnService) this._Channel).ResolveParametricData(this._UserProfile, printLabelTxn, parameters, request, out result) : this.AddMethod((Method) new PrintLabelTxnMethod(printLabelTxn, PrintLabelTxnMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) printLabelTxn, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((PrintLabelTxn) null, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus ResolveParametricData(PrintLabelTxn printLabelTxn)
    {
      return this.ResolveParametricData(printLabelTxn, (PrintLabelTxn_Parameters) null, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus ResolveParametricData(
      PrintLabelTxn printLabelTxn,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      return this.ResolveParametricData(printLabelTxn, (PrintLabelTxn_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject printLabelTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelTxn_Result result1;
        ResultStatus parametricData = this.CreateParametricData((PrintLabelTxn) printLabelTxn, (PrintLabelTxn_Parameters) parameters, (PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject printLabelTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelTxn_Result result1;
        ResultStatus actions = this.GetActions((PrintLabelTxn) printLabelTxn, (PrintLabelTxn_Parameters) parameters, (PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject printLabelTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelTxn_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((PrintLabelTxn) printLabelTxn, (PrintLabelTxn_Parameters) parameters, (PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject printLabelTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelTxn_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PrintLabelTxn) printLabelTxn, (PrintLabelTxn_LoadESigDetails_Parameters) parameters, (PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject printLabelTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelTxn_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((PrintLabelTxn) printLabelTxn, (PrintLabelTxn_Parameters) parameters, (PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject printLabelTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelTxn_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((PrintLabelTxn) printLabelTxn, (PrintLabelTxn_Parameters) parameters, (PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject printLabelTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelTxn_Result result1;
        ResultStatus resultStatus = this.Load((PrintLabelTxn) printLabelTxn, (PrintLabelTxn_Parameters) parameters, (PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject printLabelTxn,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintLabelTxn_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PrintLabelTxn) printLabelTxn, (PrintLabelTxn_Parameters) parameters, (PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      try
      {
        PrintLabelTxnMethod[] methods = new PrintLabelTxnMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPrintLabelTxnService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PrintLabelTxn_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintLabelTxn cdo,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      try
      {
        return ((IPrintLabelTxnService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PrintLabelTxn_Result result1;
        ResultStatus environment = this.GetEnvironment((PrintLabelTxn) cdo, (PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      return this.GetEnvironment((PrintLabelTxn) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PrintLabelTxn cdo,
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      result = (PrintLabelTxn_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintLabelTxnService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PrintLabelTxnMethod(cdo, PrintLabelTxnMethods.ExecuteTransaction, (PrintLabelTxn_Parameters) null));
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
        PrintLabelTxn_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PrintLabelTxn) cdo, (PrintLabelTxn_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PrintLabelTxn cdo)
    {
      return this.ExecuteTransaction(cdo, (PrintLabelTxn_Request) null, out PrintLabelTxn_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PrintLabelTxn_Request request,
      out PrintLabelTxn_Result result)
    {
      return this.ExecuteTransaction((PrintLabelTxn) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PrintLabelTxn cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PrintLabelTxnMethod(cdo, PrintLabelTxnMethods.AddDataTransaction, (PrintLabelTxn_Parameters) null));
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
        return this.AddDataTransaction((PrintLabelTxn) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
