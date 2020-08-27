// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintPELabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PrintPELabelService : PrintLabelTxnBase
  {
    public PrintPELabelService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPrintPELabelService), userProfile);
    }

    public ResultStatus CreateParametricData(
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) printPELabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelService) this._Channel).CreateParametricData(this._UserProfile, printPELabel, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelMethod(printPELabel, PrintPELabelMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) printPELabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((PrintPELabel) null, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus CreateParametricData(PrintPELabel printPELabel)
    {
      return this.CreateParametricData(printPELabel, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus CreateParametricData(
      PrintPELabel printPELabel,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      return this.CreateParametricData(printPELabel, (PrintPELabel_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) printPELabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelService) this._Channel).GetActions(this._UserProfile, printPELabel, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelMethod(printPELabel, PrintPELabelMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) printPELabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((PrintPELabel) null, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus GetActions(PrintPELabel printPELabel)
    {
      return this.GetActions(printPELabel, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus GetActions(
      PrintPELabel printPELabel,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      return this.GetActions(printPELabel, (PrintPELabel_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) printPELabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelService) this._Channel).GetDataPoints(this._UserProfile, printPELabel, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelMethod(printPELabel, PrintPELabelMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) printPELabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((PrintPELabel) null, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus GetDataPoints(PrintPELabel printPELabel)
    {
      return this.GetDataPoints(printPELabel, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus GetDataPoints(
      PrintPELabel printPELabel,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      return this.GetDataPoints(printPELabel, (PrintPELabel_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) printPELabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelService) this._Channel).GetWIPMsgs(this._UserProfile, printPELabel, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelMethod(printPELabel, PrintPELabelMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) printPELabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PrintPELabel) null, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus GetWIPMsgs(PrintPELabel printPELabel)
    {
      return this.GetWIPMsgs(printPELabel, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PrintPELabel printPELabel,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      return this.GetWIPMsgs(printPELabel, (PrintPELabel_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) printPELabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelService) this._Channel).Load(this._UserProfile, printPELabel, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelMethod(printPELabel, PrintPELabelMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) printPELabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PrintPELabel) null, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus Load(PrintPELabel printPELabel)
    {
      return this.Load(printPELabel, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus Load(
      PrintPELabel printPELabel,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      return this.Load(printPELabel, (PrintPELabel_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PrintPELabel printPELabel,
      PrintPELabel_LoadESigDetails_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) printPELabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelService) this._Channel).LoadESigDetails(this._UserProfile, printPELabel, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelMethod(printPELabel, PrintPELabelMethods.LoadESigDetails, (PrintPELabel_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) printPELabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PrintPELabel) null, (PrintPELabel_LoadESigDetails_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus LoadESigDetails(PrintPELabel printPELabel)
    {
      return this.LoadESigDetails(printPELabel, (PrintPELabel_LoadESigDetails_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus LoadESigDetails(
      PrintPELabel printPELabel,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      return this.LoadESigDetails(printPELabel, (PrintPELabel_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) printPELabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelService) this._Channel).ProcessComputation(this._UserProfile, printPELabel, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelMethod(printPELabel, PrintPELabelMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) printPELabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((PrintPELabel) null, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus ProcessComputation(PrintPELabel printPELabel)
    {
      return this.ProcessComputation(printPELabel, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus ProcessComputation(
      PrintPELabel printPELabel,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      return this.ProcessComputation(printPELabel, (PrintPELabel_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      PrintPELabel printPELabel,
      PrintPELabel_Parameters parameters,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) printPELabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelService) this._Channel).ResolveParametricData(this._UserProfile, printPELabel, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelMethod(printPELabel, PrintPELabelMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) printPELabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((PrintPELabel) null, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus ResolveParametricData(PrintPELabel printPELabel)
    {
      return this.ResolveParametricData(printPELabel, (PrintPELabel_Parameters) null, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      PrintPELabel printPELabel,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      return this.ResolveParametricData(printPELabel, (PrintPELabel_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject printPELabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabel_Result result1;
        ResultStatus parametricData = this.CreateParametricData((PrintPELabel) printPELabel, (PrintPELabel_Parameters) parameters, (PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject printPELabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabel_Result result1;
        ResultStatus actions = this.GetActions((PrintPELabel) printPELabel, (PrintPELabel_Parameters) parameters, (PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject printPELabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabel_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((PrintPELabel) printPELabel, (PrintPELabel_Parameters) parameters, (PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject printPELabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabel_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PrintPELabel) printPELabel, (PrintPELabel_LoadESigDetails_Parameters) parameters, (PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject printPELabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabel_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((PrintPELabel) printPELabel, (PrintPELabel_Parameters) parameters, (PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject printPELabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabel_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((PrintPELabel) printPELabel, (PrintPELabel_Parameters) parameters, (PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject printPELabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabel_Result result1;
        ResultStatus resultStatus = this.Load((PrintPELabel) printPELabel, (PrintPELabel_Parameters) parameters, (PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject printPELabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabel_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PrintPELabel) printPELabel, (PrintPELabel_Parameters) parameters, (PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      try
      {
        PrintPELabelMethod[] methods = new PrintPELabelMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPrintPELabelService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PrintPELabel_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintPELabel cdo,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      try
      {
        return ((IPrintPELabelService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PrintPELabel_Result result1;
        ResultStatus environment = this.GetEnvironment((PrintPELabel) cdo, (PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      return this.GetEnvironment((PrintPELabel) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PrintPELabel cdo,
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      result = (PrintPELabel_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PrintPELabelMethod(cdo, PrintPELabelMethods.ExecuteTransaction, (PrintPELabel_Parameters) null));
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
        PrintPELabel_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PrintPELabel) cdo, (PrintPELabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PrintPELabel cdo)
    {
      return this.ExecuteTransaction(cdo, (PrintPELabel_Request) null, out PrintPELabel_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PrintPELabel_Request request,
      out PrintPELabel_Result result)
    {
      return this.ExecuteTransaction((PrintPELabel) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PrintPELabel cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PrintPELabelMethod(cdo, PrintPELabelMethods.AddDataTransaction, (PrintPELabel_Parameters) null));
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
        return this.AddDataTransaction((PrintPELabel) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
