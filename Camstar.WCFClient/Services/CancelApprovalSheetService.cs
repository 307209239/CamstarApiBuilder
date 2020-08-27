// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.CancelApprovalSheetService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class CancelApprovalSheetService : QualityTxnBase
  {
    public CancelApprovalSheetService(UserProfile userProfile)
    {
      this.Initialize(typeof (ICancelApprovalSheetService), userProfile);
    }

    public ResultStatus CreateParametricData(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalSheetService) this._Channel).CreateParametricData(this._UserProfile, cancelApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalSheetMethod(cancelApprovalSheet, CancelApprovalSheetMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((CancelApprovalSheet) null, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus CreateParametricData(CancelApprovalSheet cancelApprovalSheet)
    {
      return this.CreateParametricData(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus CreateParametricData(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      return this.CreateParametricData(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalSheetService) this._Channel).GetActions(this._UserProfile, cancelApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalSheetMethod(cancelApprovalSheet, CancelApprovalSheetMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((CancelApprovalSheet) null, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus GetActions(CancelApprovalSheet cancelApprovalSheet)
    {
      return this.GetActions(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus GetActions(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      return this.GetActions(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalSheetService) this._Channel).GetDataPoints(this._UserProfile, cancelApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalSheetMethod(cancelApprovalSheet, CancelApprovalSheetMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((CancelApprovalSheet) null, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus GetDataPoints(CancelApprovalSheet cancelApprovalSheet)
    {
      return this.GetDataPoints(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus GetDataPoints(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      return this.GetDataPoints(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalSheetService) this._Channel).GetWIPMsgs(this._UserProfile, cancelApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalSheetMethod(cancelApprovalSheet, CancelApprovalSheetMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((CancelApprovalSheet) null, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus GetWIPMsgs(CancelApprovalSheet cancelApprovalSheet)
    {
      return this.GetWIPMsgs(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus GetWIPMsgs(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      return this.GetWIPMsgs(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalSheetService) this._Channel).Load(this._UserProfile, cancelApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalSheetMethod(cancelApprovalSheet, CancelApprovalSheetMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((CancelApprovalSheet) null, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus Load(CancelApprovalSheet cancelApprovalSheet)
    {
      return this.Load(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus Load(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      return this.Load(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalSheetService) this._Channel).LoadESigDetails(this._UserProfile, cancelApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalSheetMethod(cancelApprovalSheet, CancelApprovalSheetMethods.LoadESigDetails, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((CancelApprovalSheet) null, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus LoadESigDetails(CancelApprovalSheet cancelApprovalSheet)
    {
      return this.LoadESigDetails(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus LoadESigDetails(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      return this.LoadESigDetails(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalSheetService) this._Channel).ProcessComputation(this._UserProfile, cancelApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalSheetMethod(cancelApprovalSheet, CancelApprovalSheetMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((CancelApprovalSheet) null, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus ProcessComputation(CancelApprovalSheet cancelApprovalSheet)
    {
      return this.ProcessComputation(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus ProcessComputation(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      return this.ProcessComputation(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Parameters parameters,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalSheetService) this._Channel).ResolveParametricData(this._UserProfile, cancelApprovalSheet, parameters, request, out result) : this.AddMethod((Method) new CancelApprovalSheetMethod(cancelApprovalSheet, CancelApprovalSheetMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) cancelApprovalSheet, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((CancelApprovalSheet) null, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus ResolveParametricData(CancelApprovalSheet cancelApprovalSheet)
    {
      return this.ResolveParametricData(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus ResolveParametricData(
      CancelApprovalSheet cancelApprovalSheet,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      return this.ResolveParametricData(cancelApprovalSheet, (CancelApprovalSheet_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject cancelApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApprovalSheet_Result result1;
        ResultStatus parametricData = this.CreateParametricData((CancelApprovalSheet) cancelApprovalSheet, (CancelApprovalSheet_Parameters) parameters, (CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject cancelApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApprovalSheet_Result result1;
        ResultStatus actions = this.GetActions((CancelApprovalSheet) cancelApprovalSheet, (CancelApprovalSheet_Parameters) parameters, (CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject cancelApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApprovalSheet_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((CancelApprovalSheet) cancelApprovalSheet, (CancelApprovalSheet_Parameters) parameters, (CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject cancelApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApprovalSheet_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((CancelApprovalSheet) cancelApprovalSheet, (CancelApprovalSheet_Parameters) parameters, (CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject cancelApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApprovalSheet_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((CancelApprovalSheet) cancelApprovalSheet, (CancelApprovalSheet_Parameters) parameters, (CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject cancelApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApprovalSheet_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((CancelApprovalSheet) cancelApprovalSheet, (CancelApprovalSheet_Parameters) parameters, (CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject cancelApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApprovalSheet_Result result1;
        ResultStatus resultStatus = this.Load((CancelApprovalSheet) cancelApprovalSheet, (CancelApprovalSheet_Parameters) parameters, (CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject cancelApprovalSheet,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        CancelApprovalSheet_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((CancelApprovalSheet) cancelApprovalSheet, (CancelApprovalSheet_Parameters) parameters, (CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      try
      {
        CancelApprovalSheetMethod[] methods = new CancelApprovalSheetMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ICancelApprovalSheetService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        CancelApprovalSheet_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CancelApprovalSheet cdo,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      try
      {
        return ((ICancelApprovalSheetService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        CancelApprovalSheet_Result result1;
        ResultStatus environment = this.GetEnvironment((CancelApprovalSheet) cdo, (CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      return this.GetEnvironment((CancelApprovalSheet) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      CancelApprovalSheet cdo,
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      result = (CancelApprovalSheet_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ICancelApprovalSheetService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new CancelApprovalSheetMethod(cdo, CancelApprovalSheetMethods.ExecuteTransaction, (CancelApprovalSheet_Parameters) null));
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
        CancelApprovalSheet_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((CancelApprovalSheet) cdo, (CancelApprovalSheet_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(CancelApprovalSheet cdo)
    {
      return this.ExecuteTransaction(cdo, (CancelApprovalSheet_Request) null, out CancelApprovalSheet_Result _);
    }

    public ResultStatus ExecuteTransaction(
      CancelApprovalSheet_Request request,
      out CancelApprovalSheet_Result result)
    {
      return this.ExecuteTransaction((CancelApprovalSheet) null, request, out result);
    }

    public ResultStatus AddDataTransaction(CancelApprovalSheet cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new CancelApprovalSheetMethod(cdo, CancelApprovalSheetMethods.AddDataTransaction, (CancelApprovalSheet_Parameters) null));
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
        return this.AddDataTransaction((CancelApprovalSheet) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
