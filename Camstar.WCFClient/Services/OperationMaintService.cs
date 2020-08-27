// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.OperationMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class OperationMaintService : NamedDataObjectMaintBase
  {
    public OperationMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IOperationMaintService), userProfile);
    }

    public ResultStatus Delete(
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) operationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOperationMaintService) this._Channel).Delete(this._UserProfile, operationMaint, parameters, request, out result) : this.AddMethod((Method) new OperationMaintMethod(operationMaint, OperationMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) operationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((OperationMaint) null, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus Delete(OperationMaint operationMaint)
    {
      return this.Delete(operationMaint, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus Delete(
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.Delete(operationMaint, (OperationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) operationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOperationMaintService) this._Channel).Freeze(this._UserProfile, operationMaint, parameters, request, out result) : this.AddMethod((Method) new OperationMaintMethod(operationMaint, OperationMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) operationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((OperationMaint) null, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus Freeze(OperationMaint operationMaint)
    {
      return this.Freeze(operationMaint, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus Freeze(
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.Freeze(operationMaint, (OperationMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) operationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOperationMaintService) this._Channel).GetWIPMsgs(this._UserProfile, operationMaint, parameters, request, out result) : this.AddMethod((Method) new OperationMaintMethod(operationMaint, OperationMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) operationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((OperationMaint) null, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(OperationMaint operationMaint)
    {
      return this.GetWIPMsgs(operationMaint, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.GetWIPMsgs(operationMaint, (OperationMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) operationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOperationMaintService) this._Channel).Load(this._UserProfile, operationMaint, parameters, request, out result) : this.AddMethod((Method) new OperationMaintMethod(operationMaint, OperationMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) operationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((OperationMaint) null, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus Load(OperationMaint operationMaint)
    {
      return this.Load(operationMaint, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus Load(
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.Load(operationMaint, (OperationMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      OperationMaint operationMaint,
      OperationMaint_LoadESigDetails_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) operationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOperationMaintService) this._Channel).LoadESigDetails(this._UserProfile, operationMaint, parameters, request, out result) : this.AddMethod((Method) new OperationMaintMethod(operationMaint, OperationMaintMethods.LoadESigDetails, (OperationMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) operationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((OperationMaint) null, (OperationMaint_LoadESigDetails_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(OperationMaint operationMaint)
    {
      return this.LoadESigDetails(operationMaint, (OperationMaint_LoadESigDetails_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.LoadESigDetails(operationMaint, (OperationMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) operationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOperationMaintService) this._Channel).New(this._UserProfile, operationMaint, parameters, request, out result) : this.AddMethod((Method) new OperationMaintMethod(operationMaint, OperationMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) operationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((OperationMaint) null, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus New(OperationMaint operationMaint)
    {
      return this.New(operationMaint, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus New(
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.New(operationMaint, (OperationMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) operationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOperationMaintService) this._Channel).NewCopy(this._UserProfile, operationMaint, parameters, request, out result) : this.AddMethod((Method) new OperationMaintMethod(operationMaint, OperationMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) operationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((OperationMaint) null, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus NewCopy(OperationMaint operationMaint)
    {
      return this.NewCopy(operationMaint, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus NewCopy(
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.NewCopy(operationMaint, (OperationMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) operationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOperationMaintService) this._Channel).SaveAs(this._UserProfile, operationMaint, parameters, request, out result) : this.AddMethod((Method) new OperationMaintMethod(operationMaint, OperationMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) operationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((OperationMaint) null, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus SaveAs(OperationMaint operationMaint)
    {
      return this.SaveAs(operationMaint, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus SaveAs(
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.SaveAs(operationMaint, (OperationMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      OperationMaint operationMaint,
      OperationMaint_Parameters parameters,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) operationMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOperationMaintService) this._Channel).UnFreeze(this._UserProfile, operationMaint, parameters, request, out result) : this.AddMethod((Method) new OperationMaintMethod(operationMaint, OperationMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) operationMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((OperationMaint) null, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus UnFreeze(OperationMaint operationMaint)
    {
      return this.UnFreeze(operationMaint, (OperationMaint_Parameters) null, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus UnFreeze(
      OperationMaint operationMaint,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.UnFreeze(operationMaint, (OperationMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject operationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OperationMaint_Result result1;
        ResultStatus resultStatus = this.Delete((OperationMaint) operationMaint, (OperationMaint_Parameters) parameters, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject operationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OperationMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((OperationMaint) operationMaint, (OperationMaint_Parameters) parameters, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject operationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OperationMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((OperationMaint) operationMaint, (OperationMaint_LoadESigDetails_Parameters) parameters, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject operationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OperationMaint_Result result1;
        ResultStatus resultStatus = this.New((OperationMaint) operationMaint, (OperationMaint_Parameters) parameters, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject operationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OperationMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((OperationMaint) operationMaint, (OperationMaint_Parameters) parameters, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject operationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OperationMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((OperationMaint) operationMaint, (OperationMaint_Parameters) parameters, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject operationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OperationMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((OperationMaint) operationMaint, (OperationMaint_Parameters) parameters, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject operationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OperationMaint_Result result1;
        ResultStatus resultStatus = this.Load((OperationMaint) operationMaint, (OperationMaint_Parameters) parameters, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject operationMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        OperationMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((OperationMaint) operationMaint, (OperationMaint_Parameters) parameters, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      try
      {
        OperationMaintMethod[] methods = new OperationMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IOperationMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        OperationMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OperationMaint cdo,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      try
      {
        return ((IOperationMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        OperationMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((OperationMaint) cdo, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.GetEnvironment((OperationMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      OperationMaint cdo,
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      result = (OperationMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IOperationMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new OperationMaintMethod(cdo, OperationMaintMethods.ExecuteTransaction, (OperationMaint_Parameters) null));
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
        OperationMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((OperationMaint) cdo, (OperationMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(OperationMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (OperationMaint_Request) null, out OperationMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      OperationMaint_Request request,
      out OperationMaint_Result result)
    {
      return this.ExecuteTransaction((OperationMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(OperationMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new OperationMaintMethod(cdo, OperationMaintMethods.AddDataTransaction, (OperationMaint_Parameters) null));
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
        return this.AddDataTransaction((OperationMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
