// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintQualityObjectLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PrintQualityObjectLabelService : PrintLabelTxnBase
  {
    public PrintQualityObjectLabelService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPrintQualityObjectLabelService), userProfile);
    }

    public ResultStatus CreateParametricData(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQualityObjectLabelService) this._Channel).CreateParametricData(this._UserProfile, printQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new PrintQualityObjectLabelMethod(printQualityObjectLabel, PrintQualityObjectLabelMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((PrintQualityObjectLabel) null, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus CreateParametricData(
      PrintQualityObjectLabel printQualityObjectLabel)
    {
      return this.CreateParametricData(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus CreateParametricData(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      return this.CreateParametricData(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQualityObjectLabelService) this._Channel).GetActions(this._UserProfile, printQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new PrintQualityObjectLabelMethod(printQualityObjectLabel, PrintQualityObjectLabelMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((PrintQualityObjectLabel) null, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus GetActions(PrintQualityObjectLabel printQualityObjectLabel)
    {
      return this.GetActions(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus GetActions(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      return this.GetActions(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQualityObjectLabelService) this._Channel).GetDataPoints(this._UserProfile, printQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new PrintQualityObjectLabelMethod(printQualityObjectLabel, PrintQualityObjectLabelMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((PrintQualityObjectLabel) null, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus GetDataPoints(PrintQualityObjectLabel printQualityObjectLabel)
    {
      return this.GetDataPoints(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus GetDataPoints(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      return this.GetDataPoints(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQualityObjectLabelService) this._Channel).GetWIPMsgs(this._UserProfile, printQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new PrintQualityObjectLabelMethod(printQualityObjectLabel, PrintQualityObjectLabelMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PrintQualityObjectLabel) null, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(PrintQualityObjectLabel printQualityObjectLabel)
    {
      return this.GetWIPMsgs(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      return this.GetWIPMsgs(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQualityObjectLabelService) this._Channel).Load(this._UserProfile, printQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new PrintQualityObjectLabelMethod(printQualityObjectLabel, PrintQualityObjectLabelMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PrintQualityObjectLabel) null, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus Load(PrintQualityObjectLabel printQualityObjectLabel)
    {
      return this.Load(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus Load(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      return this.Load(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_LoadESigDetails_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQualityObjectLabelService) this._Channel).LoadESigDetails(this._UserProfile, printQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new PrintQualityObjectLabelMethod(printQualityObjectLabel, PrintQualityObjectLabelMethods.LoadESigDetails, (PrintQualityObjectLabel_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PrintQualityObjectLabel) null, (PrintQualityObjectLabel_LoadESigDetails_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus LoadESigDetails(PrintQualityObjectLabel printQualityObjectLabel)
    {
      return this.LoadESigDetails(printQualityObjectLabel, (PrintQualityObjectLabel_LoadESigDetails_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus LoadESigDetails(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      return this.LoadESigDetails(printQualityObjectLabel, (PrintQualityObjectLabel_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQualityObjectLabelService) this._Channel).ProcessComputation(this._UserProfile, printQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new PrintQualityObjectLabelMethod(printQualityObjectLabel, PrintQualityObjectLabelMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((PrintQualityObjectLabel) null, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus ProcessComputation(
      PrintQualityObjectLabel printQualityObjectLabel)
    {
      return this.ProcessComputation(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus ProcessComputation(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      return this.ProcessComputation(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Parameters parameters,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQualityObjectLabelService) this._Channel).ResolveParametricData(this._UserProfile, printQualityObjectLabel, parameters, request, out result) : this.AddMethod((Method) new PrintQualityObjectLabelMethod(printQualityObjectLabel, PrintQualityObjectLabelMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) printQualityObjectLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((PrintQualityObjectLabel) null, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      PrintQualityObjectLabel printQualityObjectLabel)
    {
      return this.ResolveParametricData(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      PrintQualityObjectLabel printQualityObjectLabel,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      return this.ResolveParametricData(printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject printQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQualityObjectLabel_Result result1;
        ResultStatus parametricData = this.CreateParametricData((PrintQualityObjectLabel) printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) parameters, (PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject printQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQualityObjectLabel_Result result1;
        ResultStatus actions = this.GetActions((PrintQualityObjectLabel) printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) parameters, (PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject printQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQualityObjectLabel_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((PrintQualityObjectLabel) printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) parameters, (PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject printQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PrintQualityObjectLabel) printQualityObjectLabel, (PrintQualityObjectLabel_LoadESigDetails_Parameters) parameters, (PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject printQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((PrintQualityObjectLabel) printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) parameters, (PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject printQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((PrintQualityObjectLabel) printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) parameters, (PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject printQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.Load((PrintQualityObjectLabel) printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) parameters, (PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject printQualityObjectLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintQualityObjectLabel_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PrintQualityObjectLabel) printQualityObjectLabel, (PrintQualityObjectLabel_Parameters) parameters, (PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      try
      {
        PrintQualityObjectLabelMethod[] methods = new PrintQualityObjectLabelMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPrintQualityObjectLabelService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PrintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintQualityObjectLabel cdo,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      try
      {
        return ((IPrintQualityObjectLabelService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PrintQualityObjectLabel_Result result1;
        ResultStatus environment = this.GetEnvironment((PrintQualityObjectLabel) cdo, (PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      return this.GetEnvironment((PrintQualityObjectLabel) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PrintQualityObjectLabel cdo,
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      result = (PrintQualityObjectLabel_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintQualityObjectLabelService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PrintQualityObjectLabelMethod(cdo, PrintQualityObjectLabelMethods.ExecuteTransaction, (PrintQualityObjectLabel_Parameters) null));
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
        PrintQualityObjectLabel_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PrintQualityObjectLabel) cdo, (PrintQualityObjectLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PrintQualityObjectLabel cdo)
    {
      return this.ExecuteTransaction(cdo, (PrintQualityObjectLabel_Request) null, out PrintQualityObjectLabel_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PrintQualityObjectLabel_Request request,
      out PrintQualityObjectLabel_Result result)
    {
      return this.ExecuteTransaction((PrintQualityObjectLabel) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PrintQualityObjectLabel cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PrintQualityObjectLabelMethod(cdo, PrintQualityObjectLabelMethods.AddDataTransaction, (PrintQualityObjectLabel_Parameters) null));
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
        return this.AddDataTransaction((PrintQualityObjectLabel) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
