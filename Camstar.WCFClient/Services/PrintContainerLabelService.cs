// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintContainerLabelService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PrintContainerLabelService : PrintLabelTxnBase
  {
    public PrintContainerLabelService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPrintContainerLabelService), userProfile);
    }

    public ResultStatus CreateParametricData(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) printContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintContainerLabelService) this._Channel).CreateParametricData(this._UserProfile, printContainerLabel, parameters, request, out result) : this.AddMethod((Method) new PrintContainerLabelMethod(printContainerLabel, PrintContainerLabelMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) printContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((PrintContainerLabel) null, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus CreateParametricData(PrintContainerLabel printContainerLabel)
    {
      return this.CreateParametricData(printContainerLabel, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus CreateParametricData(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.CreateParametricData(printContainerLabel, (PrintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) printContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintContainerLabelService) this._Channel).GetActions(this._UserProfile, printContainerLabel, parameters, request, out result) : this.AddMethod((Method) new PrintContainerLabelMethod(printContainerLabel, PrintContainerLabelMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) printContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((PrintContainerLabel) null, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus GetActions(PrintContainerLabel printContainerLabel)
    {
      return this.GetActions(printContainerLabel, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus GetActions(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.GetActions(printContainerLabel, (PrintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) printContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintContainerLabelService) this._Channel).GetDataPoints(this._UserProfile, printContainerLabel, parameters, request, out result) : this.AddMethod((Method) new PrintContainerLabelMethod(printContainerLabel, PrintContainerLabelMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) printContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((PrintContainerLabel) null, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus GetDataPoints(PrintContainerLabel printContainerLabel)
    {
      return this.GetDataPoints(printContainerLabel, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus GetDataPoints(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.GetDataPoints(printContainerLabel, (PrintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetLabelInformation(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (GetLabelInformation), (DCObject) printContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintContainerLabelService) this._Channel).GetLabelInformation(this._UserProfile, printContainerLabel, parameters, request, out result) : this.AddMethod((Method) new PrintContainerLabelMethod(printContainerLabel, PrintContainerLabelMethods.GetLabelInformation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetLabelInformation), res, (DCObject) printContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetLabelInformation()
    {
      return this.GetLabelInformation((PrintContainerLabel) null, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus GetLabelInformation(PrintContainerLabel printContainerLabel)
    {
      return this.GetLabelInformation(printContainerLabel, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus GetLabelInformation(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.GetLabelInformation(printContainerLabel, (PrintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) printContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintContainerLabelService) this._Channel).GetWIPMsgs(this._UserProfile, printContainerLabel, parameters, request, out result) : this.AddMethod((Method) new PrintContainerLabelMethod(printContainerLabel, PrintContainerLabelMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) printContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PrintContainerLabel) null, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(PrintContainerLabel printContainerLabel)
    {
      return this.GetWIPMsgs(printContainerLabel, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.GetWIPMsgs(printContainerLabel, (PrintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) printContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintContainerLabelService) this._Channel).Load(this._UserProfile, printContainerLabel, parameters, request, out result) : this.AddMethod((Method) new PrintContainerLabelMethod(printContainerLabel, PrintContainerLabelMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) printContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PrintContainerLabel) null, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus Load(PrintContainerLabel printContainerLabel)
    {
      return this.Load(printContainerLabel, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus Load(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.Load(printContainerLabel, (PrintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_LoadESigDetails_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) printContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintContainerLabelService) this._Channel).LoadESigDetails(this._UserProfile, printContainerLabel, parameters, request, out result) : this.AddMethod((Method) new PrintContainerLabelMethod(printContainerLabel, PrintContainerLabelMethods.LoadESigDetails, (PrintContainerLabel_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) printContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PrintContainerLabel) null, (PrintContainerLabel_LoadESigDetails_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus LoadESigDetails(PrintContainerLabel printContainerLabel)
    {
      return this.LoadESigDetails(printContainerLabel, (PrintContainerLabel_LoadESigDetails_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus LoadESigDetails(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.LoadESigDetails(printContainerLabel, (PrintContainerLabel_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) printContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintContainerLabelService) this._Channel).ProcessComputation(this._UserProfile, printContainerLabel, parameters, request, out result) : this.AddMethod((Method) new PrintContainerLabelMethod(printContainerLabel, PrintContainerLabelMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) printContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((PrintContainerLabel) null, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus ProcessComputation(PrintContainerLabel printContainerLabel)
    {
      return this.ProcessComputation(printContainerLabel, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus ProcessComputation(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.ProcessComputation(printContainerLabel, (PrintContainerLabel_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Parameters parameters,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) printContainerLabel, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintContainerLabelService) this._Channel).ResolveParametricData(this._UserProfile, printContainerLabel, parameters, request, out result) : this.AddMethod((Method) new PrintContainerLabelMethod(printContainerLabel, PrintContainerLabelMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) printContainerLabel, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((PrintContainerLabel) null, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus ResolveParametricData(PrintContainerLabel printContainerLabel)
    {
      return this.ResolveParametricData(printContainerLabel, (PrintContainerLabel_Parameters) null, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus ResolveParametricData(
      PrintContainerLabel printContainerLabel,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.ResolveParametricData(printContainerLabel, (PrintContainerLabel_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject printContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintContainerLabel_Result result1;
        ResultStatus parametricData = this.CreateParametricData((PrintContainerLabel) printContainerLabel, (PrintContainerLabel_Parameters) parameters, (PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject printContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintContainerLabel_Result result1;
        ResultStatus actions = this.GetActions((PrintContainerLabel) printContainerLabel, (PrintContainerLabel_Parameters) parameters, (PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject printContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintContainerLabel_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((PrintContainerLabel) printContainerLabel, (PrintContainerLabel_Parameters) parameters, (PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject printContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintContainerLabel_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PrintContainerLabel) printContainerLabel, (PrintContainerLabel_LoadESigDetails_Parameters) parameters, (PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject printContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintContainerLabel_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((PrintContainerLabel) printContainerLabel, (PrintContainerLabel_Parameters) parameters, (PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject printContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintContainerLabel_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((PrintContainerLabel) printContainerLabel, (PrintContainerLabel_Parameters) parameters, (PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject printContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintContainerLabel_Result result1;
        ResultStatus resultStatus = this.Load((PrintContainerLabel) printContainerLabel, (PrintContainerLabel_Parameters) parameters, (PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject printContainerLabel,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintContainerLabel_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PrintContainerLabel) printContainerLabel, (PrintContainerLabel_Parameters) parameters, (PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      try
      {
        PrintContainerLabelMethod[] methods = new PrintContainerLabelMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPrintContainerLabelService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PrintContainerLabel_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintContainerLabel cdo,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      try
      {
        return ((IPrintContainerLabelService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PrintContainerLabel_Result result1;
        ResultStatus environment = this.GetEnvironment((PrintContainerLabel) cdo, (PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.GetEnvironment((PrintContainerLabel) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PrintContainerLabel cdo,
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      result = (PrintContainerLabel_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintContainerLabelService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PrintContainerLabelMethod(cdo, PrintContainerLabelMethods.ExecuteTransaction, (PrintContainerLabel_Parameters) null));
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
        PrintContainerLabel_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PrintContainerLabel) cdo, (PrintContainerLabel_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PrintContainerLabel cdo)
    {
      return this.ExecuteTransaction(cdo, (PrintContainerLabel_Request) null, out PrintContainerLabel_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PrintContainerLabel_Request request,
      out PrintContainerLabel_Result result)
    {
      return this.ExecuteTransaction((PrintContainerLabel) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PrintContainerLabel cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PrintContainerLabelMethod(cdo, PrintContainerLabelMethods.AddDataTransaction, (PrintContainerLabel_Parameters) null));
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
        return this.AddDataTransaction((PrintContainerLabel) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
