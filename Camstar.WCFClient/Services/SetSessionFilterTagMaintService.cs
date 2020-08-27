// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SetSessionFilterTagMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SetSessionFilterTagMaintService : EmployeeMaintBase
  {
    public SetSessionFilterTagMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISetSessionFilterTagMaintService), userProfile);
    }

    public ResultStatus Delete(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetSessionFilterTagMaintService) this._Channel).Delete(this._UserProfile, setSessionFilterTagMaint, parameters, request, out result) : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(setSessionFilterTagMaint, SetSessionFilterTagMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SetSessionFilterTagMaint) null, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus Delete(SetSessionFilterTagMaint setSessionFilterTagMaint)
    {
      return this.Delete(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus Delete(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.Delete(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetSessionFilterTagMaintService) this._Channel).Freeze(this._UserProfile, setSessionFilterTagMaint, parameters, request, out result) : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(setSessionFilterTagMaint, SetSessionFilterTagMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SetSessionFilterTagMaint) null, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus Freeze(SetSessionFilterTagMaint setSessionFilterTagMaint)
    {
      return this.Freeze(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus Freeze(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.Freeze(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetSessionFilterTagMaintService) this._Channel).GetWIPMsgs(this._UserProfile, setSessionFilterTagMaint, parameters, request, out result) : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(setSessionFilterTagMaint, SetSessionFilterTagMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SetSessionFilterTagMaint) null, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SetSessionFilterTagMaint setSessionFilterTagMaint)
    {
      return this.GetWIPMsgs(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.GetWIPMsgs(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetSessionFilterTagMaintService) this._Channel).Load(this._UserProfile, setSessionFilterTagMaint, parameters, request, out result) : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(setSessionFilterTagMaint, SetSessionFilterTagMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SetSessionFilterTagMaint) null, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus Load(SetSessionFilterTagMaint setSessionFilterTagMaint)
    {
      return this.Load(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus Load(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.Load(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_LoadESigDetails_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetSessionFilterTagMaintService) this._Channel).LoadESigDetails(this._UserProfile, setSessionFilterTagMaint, parameters, request, out result) : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(setSessionFilterTagMaint, SetSessionFilterTagMaintMethods.LoadESigDetails, (SetSessionFilterTagMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SetSessionFilterTagMaint) null, (SetSessionFilterTagMaint_LoadESigDetails_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SetSessionFilterTagMaint setSessionFilterTagMaint)
    {
      return this.LoadESigDetails(setSessionFilterTagMaint, (SetSessionFilterTagMaint_LoadESigDetails_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.LoadESigDetails(setSessionFilterTagMaint, (SetSessionFilterTagMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetSessionFilterTagMaintService) this._Channel).New(this._UserProfile, setSessionFilterTagMaint, parameters, request, out result) : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(setSessionFilterTagMaint, SetSessionFilterTagMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SetSessionFilterTagMaint) null, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus New(SetSessionFilterTagMaint setSessionFilterTagMaint)
    {
      return this.New(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus New(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.New(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetSessionFilterTagMaintService) this._Channel).NewCopy(this._UserProfile, setSessionFilterTagMaint, parameters, request, out result) : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(setSessionFilterTagMaint, SetSessionFilterTagMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SetSessionFilterTagMaint) null, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus NewCopy(SetSessionFilterTagMaint setSessionFilterTagMaint)
    {
      return this.NewCopy(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus NewCopy(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.NewCopy(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetSessionFilterTagMaintService) this._Channel).SaveAs(this._UserProfile, setSessionFilterTagMaint, parameters, request, out result) : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(setSessionFilterTagMaint, SetSessionFilterTagMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SetSessionFilterTagMaint) null, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus SaveAs(SetSessionFilterTagMaint setSessionFilterTagMaint)
    {
      return this.SaveAs(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus SaveAs(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.SaveAs(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Parameters parameters,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetSessionFilterTagMaintService) this._Channel).UnFreeze(this._UserProfile, setSessionFilterTagMaint, parameters, request, out result) : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(setSessionFilterTagMaint, SetSessionFilterTagMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) setSessionFilterTagMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SetSessionFilterTagMaint) null, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus UnFreeze(SetSessionFilterTagMaint setSessionFilterTagMaint)
    {
      return this.UnFreeze(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SetSessionFilterTagMaint setSessionFilterTagMaint,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.UnFreeze(setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject setSessionFilterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetSessionFilterTagMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SetSessionFilterTagMaint) setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) parameters, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject setSessionFilterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetSessionFilterTagMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SetSessionFilterTagMaint) setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) parameters, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject setSessionFilterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetSessionFilterTagMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SetSessionFilterTagMaint) setSessionFilterTagMaint, (SetSessionFilterTagMaint_LoadESigDetails_Parameters) parameters, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject setSessionFilterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetSessionFilterTagMaint_Result result1;
        ResultStatus resultStatus = this.New((SetSessionFilterTagMaint) setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) parameters, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject setSessionFilterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetSessionFilterTagMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SetSessionFilterTagMaint) setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) parameters, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject setSessionFilterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetSessionFilterTagMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SetSessionFilterTagMaint) setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) parameters, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject setSessionFilterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetSessionFilterTagMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SetSessionFilterTagMaint) setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) parameters, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject setSessionFilterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetSessionFilterTagMaint_Result result1;
        ResultStatus resultStatus = this.Load((SetSessionFilterTagMaint) setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) parameters, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject setSessionFilterTagMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SetSessionFilterTagMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SetSessionFilterTagMaint) setSessionFilterTagMaint, (SetSessionFilterTagMaint_Parameters) parameters, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      try
      {
        SetSessionFilterTagMaintMethod[] methods = new SetSessionFilterTagMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISetSessionFilterTagMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SetSessionFilterTagMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SetSessionFilterTagMaint cdo,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      try
      {
        return ((ISetSessionFilterTagMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SetSessionFilterTagMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SetSessionFilterTagMaint) cdo, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.GetEnvironment((SetSessionFilterTagMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SetSessionFilterTagMaint cdo,
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      result = (SetSessionFilterTagMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISetSessionFilterTagMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(cdo, SetSessionFilterTagMaintMethods.ExecuteTransaction, (SetSessionFilterTagMaint_Parameters) null));
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
        SetSessionFilterTagMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SetSessionFilterTagMaint) cdo, (SetSessionFilterTagMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SetSessionFilterTagMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SetSessionFilterTagMaint_Request) null, out SetSessionFilterTagMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SetSessionFilterTagMaint_Request request,
      out SetSessionFilterTagMaint_Result result)
    {
      return this.ExecuteTransaction((SetSessionFilterTagMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SetSessionFilterTagMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SetSessionFilterTagMaintMethod(cdo, SetSessionFilterTagMaintMethods.AddDataTransaction, (SetSessionFilterTagMaint_Parameters) null));
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
        return this.AddDataTransaction((SetSessionFilterTagMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
