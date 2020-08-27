// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintNCRLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PrintNCRLabelService : PrintLabelTxnBase
  {
    public PrintNCRLabelService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPrintNCRLabelService), userProfile);
    }

    public ResultStatus CreateParametricData(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) printNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintNCRLabelService) this._Channel).CreateParametricData(this._UserProfile, printNCRLabel, parameters, request, out result) : this.AddMethod((Method) new PrintNCRLabelMethod(printNCRLabel, PrintNCRLabelMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) printNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((PrintNCRLabel) null, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus CreateParametricData(PrintNCRLabel printNCRLabel)
    {
      return this.CreateParametricData(printNCRLabel, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus CreateParametricData(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      return this.CreateParametricData(printNCRLabel, (PrintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) printNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintNCRLabelService) this._Channel).GetActions(this._UserProfile, printNCRLabel, parameters, request, out result) : this.AddMethod((Method) new PrintNCRLabelMethod(printNCRLabel, PrintNCRLabelMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) printNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((PrintNCRLabel) null, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus GetActions(PrintNCRLabel printNCRLabel)
    {
      return this.GetActions(printNCRLabel, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus GetActions(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      return this.GetActions(printNCRLabel, (PrintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) printNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintNCRLabelService) this._Channel).GetDataPoints(this._UserProfile, printNCRLabel, parameters, request, out result) : this.AddMethod((Method) new PrintNCRLabelMethod(printNCRLabel, PrintNCRLabelMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) printNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((PrintNCRLabel) null, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus GetDataPoints(PrintNCRLabel printNCRLabel)
    {
      return this.GetDataPoints(printNCRLabel, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus GetDataPoints(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      return this.GetDataPoints(printNCRLabel, (PrintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) printNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintNCRLabelService) this._Channel).GetWIPMsgs(this._UserProfile, printNCRLabel, parameters, request, out result) : this.AddMethod((Method) new PrintNCRLabelMethod(printNCRLabel, PrintNCRLabelMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) printNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PrintNCRLabel) null, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(PrintNCRLabel printNCRLabel)
    {
      return this.GetWIPMsgs(printNCRLabel, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      return this.GetWIPMsgs(printNCRLabel, (PrintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) printNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintNCRLabelService) this._Channel).Load(this._UserProfile, printNCRLabel, parameters, request, out result) : this.AddMethod((Method) new PrintNCRLabelMethod(printNCRLabel, PrintNCRLabelMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) printNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PrintNCRLabel) null, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus Load(PrintNCRLabel printNCRLabel)
    {
      return this.Load(printNCRLabel, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus Load(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      return this.Load(printNCRLabel, (PrintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_LoadESigDetails_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) printNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintNCRLabelService) this._Channel).LoadESigDetails(this._UserProfile, printNCRLabel, parameters, request, out result) : this.AddMethod((Method) new PrintNCRLabelMethod(printNCRLabel, PrintNCRLabelMethods.LoadESigDetails, (PrintNCRLabel_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) printNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PrintNCRLabel) null, (PrintNCRLabel_LoadESigDetails_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus LoadESigDetails(PrintNCRLabel printNCRLabel)
    {
      return this.LoadESigDetails(printNCRLabel, (PrintNCRLabel_LoadESigDetails_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus LoadESigDetails(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      return this.LoadESigDetails(printNCRLabel, (PrintNCRLabel_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) printNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintNCRLabelService) this._Channel).ProcessComputation(this._UserProfile, printNCRLabel, parameters, request, out result) : this.AddMethod((Method) new PrintNCRLabelMethod(printNCRLabel, PrintNCRLabelMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) printNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((PrintNCRLabel) null, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus ProcessComputation(PrintNCRLabel printNCRLabel)
    {
      return this.ProcessComputation(printNCRLabel, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus ProcessComputation(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      return this.ProcessComputation(printNCRLabel, (PrintNCRLabel_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Parameters parameters,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) printNCRLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintNCRLabelService) this._Channel).ResolveParametricData(this._UserProfile, printNCRLabel, parameters, request, out result) : this.AddMethod((Method) new PrintNCRLabelMethod(printNCRLabel, PrintNCRLabelMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) printNCRLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((PrintNCRLabel) null, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus ResolveParametricData(PrintNCRLabel printNCRLabel)
    {
      return this.ResolveParametricData(printNCRLabel, (PrintNCRLabel_Parameters) null, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      PrintNCRLabel printNCRLabel,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      return this.ResolveParametricData(printNCRLabel, (PrintNCRLabel_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject printNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintNCRLabel_Result result1;
        ResultStatus parametricData = this.CreateParametricData((PrintNCRLabel) printNCRLabel, (PrintNCRLabel_Parameters) parameters, (PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject printNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintNCRLabel_Result result1;
        ResultStatus actions = this.GetActions((PrintNCRLabel) printNCRLabel, (PrintNCRLabel_Parameters) parameters, (PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject printNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintNCRLabel_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((PrintNCRLabel) printNCRLabel, (PrintNCRLabel_Parameters) parameters, (PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject printNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintNCRLabel_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PrintNCRLabel) printNCRLabel, (PrintNCRLabel_LoadESigDetails_Parameters) parameters, (PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject printNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintNCRLabel_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((PrintNCRLabel) printNCRLabel, (PrintNCRLabel_Parameters) parameters, (PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject printNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintNCRLabel_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((PrintNCRLabel) printNCRLabel, (PrintNCRLabel_Parameters) parameters, (PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject printNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintNCRLabel_Result result1;
        ResultStatus resultStatus = this.Load((PrintNCRLabel) printNCRLabel, (PrintNCRLabel_Parameters) parameters, (PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject printNCRLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintNCRLabel_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PrintNCRLabel) printNCRLabel, (PrintNCRLabel_Parameters) parameters, (PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      try
      {
        PrintNCRLabelMethod[] methods = new PrintNCRLabelMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPrintNCRLabelService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PrintNCRLabel_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintNCRLabel cdo,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      try
      {
        return ((IPrintNCRLabelService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PrintNCRLabel_Result result1;
        ResultStatus environment = this.GetEnvironment((PrintNCRLabel) cdo, (PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      return this.GetEnvironment((PrintNCRLabel) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PrintNCRLabel cdo,
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      result = (PrintNCRLabel_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintNCRLabelService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PrintNCRLabelMethod(cdo, PrintNCRLabelMethods.ExecuteTransaction, (PrintNCRLabel_Parameters) null));
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
        PrintNCRLabel_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PrintNCRLabel) cdo, (PrintNCRLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PrintNCRLabel cdo)
    {
      return this.ExecuteTransaction(cdo, (PrintNCRLabel_Request) null, out PrintNCRLabel_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PrintNCRLabel_Request request,
      out PrintNCRLabel_Result result)
    {
      return this.ExecuteTransaction((PrintNCRLabel) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PrintNCRLabel cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PrintNCRLabelMethod(cdo, PrintNCRLabelMethods.AddDataTransaction, (PrintNCRLabel_Parameters) null));
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
        return this.AddDataTransaction((PrintNCRLabel) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
