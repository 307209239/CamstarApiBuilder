// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PrintPELabelsService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PrintPELabelsService : PrintLabelsTxnBase
  {
    public PrintPELabelsService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPrintPELabelsService), userProfile);
    }

    public ResultStatus CreateParametricData(
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) printPELabels, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelsService) this._Channel).CreateParametricData(this._UserProfile, printPELabels, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelsMethod(printPELabels, PrintPELabelsMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) printPELabels, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((PrintPELabels) null, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus CreateParametricData(PrintPELabels printPELabels)
    {
      return this.CreateParametricData(printPELabels, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus CreateParametricData(
      PrintPELabels printPELabels,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      return this.CreateParametricData(printPELabels, (PrintPELabels_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) printPELabels, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelsService) this._Channel).GetActions(this._UserProfile, printPELabels, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelsMethod(printPELabels, PrintPELabelsMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) printPELabels, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((PrintPELabels) null, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus GetActions(PrintPELabels printPELabels)
    {
      return this.GetActions(printPELabels, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus GetActions(
      PrintPELabels printPELabels,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      return this.GetActions(printPELabels, (PrintPELabels_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) printPELabels, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelsService) this._Channel).GetDataPoints(this._UserProfile, printPELabels, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelsMethod(printPELabels, PrintPELabelsMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) printPELabels, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((PrintPELabels) null, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus GetDataPoints(PrintPELabels printPELabels)
    {
      return this.GetDataPoints(printPELabels, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus GetDataPoints(
      PrintPELabels printPELabels,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      return this.GetDataPoints(printPELabels, (PrintPELabels_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) printPELabels, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelsService) this._Channel).GetWIPMsgs(this._UserProfile, printPELabels, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelsMethod(printPELabels, PrintPELabelsMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) printPELabels, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PrintPELabels) null, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus GetWIPMsgs(PrintPELabels printPELabels)
    {
      return this.GetWIPMsgs(printPELabels, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PrintPELabels printPELabels,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      return this.GetWIPMsgs(printPELabels, (PrintPELabels_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) printPELabels, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelsService) this._Channel).Load(this._UserProfile, printPELabels, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelsMethod(printPELabels, PrintPELabelsMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) printPELabels, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PrintPELabels) null, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus Load(PrintPELabels printPELabels)
    {
      return this.Load(printPELabels, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus Load(
      PrintPELabels printPELabels,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      return this.Load(printPELabels, (PrintPELabels_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PrintPELabels printPELabels,
      PrintPELabels_LoadESigDetails_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) printPELabels, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelsService) this._Channel).LoadESigDetails(this._UserProfile, printPELabels, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelsMethod(printPELabels, PrintPELabelsMethods.LoadESigDetails, (PrintPELabels_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) printPELabels, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PrintPELabels) null, (PrintPELabels_LoadESigDetails_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus LoadESigDetails(PrintPELabels printPELabels)
    {
      return this.LoadESigDetails(printPELabels, (PrintPELabels_LoadESigDetails_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus LoadESigDetails(
      PrintPELabels printPELabels,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      return this.LoadESigDetails(printPELabels, (PrintPELabels_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) printPELabels, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelsService) this._Channel).ProcessComputation(this._UserProfile, printPELabels, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelsMethod(printPELabels, PrintPELabelsMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) printPELabels, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((PrintPELabels) null, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus ProcessComputation(PrintPELabels printPELabels)
    {
      return this.ProcessComputation(printPELabels, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus ProcessComputation(
      PrintPELabels printPELabels,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      return this.ProcessComputation(printPELabels, (PrintPELabels_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      PrintPELabels printPELabels,
      PrintPELabels_Parameters parameters,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) printPELabels, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelsService) this._Channel).ResolveParametricData(this._UserProfile, printPELabels, parameters, request, out result) : this.AddMethod((Method) new PrintPELabelsMethod(printPELabels, PrintPELabelsMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) printPELabels, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((PrintPELabels) null, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus ResolveParametricData(PrintPELabels printPELabels)
    {
      return this.ResolveParametricData(printPELabels, (PrintPELabels_Parameters) null, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus ResolveParametricData(
      PrintPELabels printPELabels,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      return this.ResolveParametricData(printPELabels, (PrintPELabels_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject printPELabels,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabels_Result result1;
        ResultStatus parametricData = this.CreateParametricData((PrintPELabels) printPELabels, (PrintPELabels_Parameters) parameters, (PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject printPELabels,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabels_Result result1;
        ResultStatus actions = this.GetActions((PrintPELabels) printPELabels, (PrintPELabels_Parameters) parameters, (PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject printPELabels,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabels_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((PrintPELabels) printPELabels, (PrintPELabels_Parameters) parameters, (PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject printPELabels,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabels_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PrintPELabels) printPELabels, (PrintPELabels_LoadESigDetails_Parameters) parameters, (PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject printPELabels,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabels_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((PrintPELabels) printPELabels, (PrintPELabels_Parameters) parameters, (PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject printPELabels,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabels_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((PrintPELabels) printPELabels, (PrintPELabels_Parameters) parameters, (PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject printPELabels,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabels_Result result1;
        ResultStatus resultStatus = this.Load((PrintPELabels) printPELabels, (PrintPELabels_Parameters) parameters, (PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject printPELabels,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PrintPELabels_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PrintPELabels) printPELabels, (PrintPELabels_Parameters) parameters, (PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      try
      {
        PrintPELabelsMethod[] methods = new PrintPELabelsMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPrintPELabelsService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PrintPELabels_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintPELabels cdo,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      try
      {
        return ((IPrintPELabelsService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PrintPELabels_Result result1;
        ResultStatus environment = this.GetEnvironment((PrintPELabels) cdo, (PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      return this.GetEnvironment((PrintPELabels) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PrintPELabels cdo,
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      result = (PrintPELabels_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPrintPELabelsService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PrintPELabelsMethod(cdo, PrintPELabelsMethods.ExecuteTransaction, (PrintPELabels_Parameters) null));
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
        PrintPELabels_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PrintPELabels) cdo, (PrintPELabels_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PrintPELabels cdo)
    {
      return this.ExecuteTransaction(cdo, (PrintPELabels_Request) null, out PrintPELabels_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PrintPELabels_Request request,
      out PrintPELabels_Result result)
    {
      return this.ExecuteTransaction((PrintPELabels) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PrintPELabels cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PrintPELabelsMethod(cdo, PrintPELabelsMethods.AddDataTransaction, (PrintPELabels_Parameters) null));
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
        return this.AddDataTransaction((PrintPELabels) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
