// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.UOMMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class UOMMaintService : UserCodeWithWMMaintBase
  {
    public UOMMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IUOMMaintService), userProfile);
    }

    public ResultStatus Delete(
      UOMMaint uOMMaint,
      UOMMaint_Parameters parameters,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) uOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUOMMaintService) this._Channel).Delete(this._UserProfile, uOMMaint, parameters, request, out result) : this.AddMethod((Method) new UOMMaintMethod(uOMMaint, UOMMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) uOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((UOMMaint) null, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus Delete(UOMMaint uOMMaint)
    {
      return this.Delete(uOMMaint, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus Delete(
      UOMMaint uOMMaint,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.Delete(uOMMaint, (UOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      UOMMaint uOMMaint,
      UOMMaint_Parameters parameters,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) uOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUOMMaintService) this._Channel).Freeze(this._UserProfile, uOMMaint, parameters, request, out result) : this.AddMethod((Method) new UOMMaintMethod(uOMMaint, UOMMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) uOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((UOMMaint) null, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus Freeze(UOMMaint uOMMaint)
    {
      return this.Freeze(uOMMaint, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus Freeze(
      UOMMaint uOMMaint,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.Freeze(uOMMaint, (UOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      UOMMaint uOMMaint,
      UOMMaint_Parameters parameters,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) uOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUOMMaintService) this._Channel).GetWIPMsgs(this._UserProfile, uOMMaint, parameters, request, out result) : this.AddMethod((Method) new UOMMaintMethod(uOMMaint, UOMMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) uOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((UOMMaint) null, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(UOMMaint uOMMaint)
    {
      return this.GetWIPMsgs(uOMMaint, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      UOMMaint uOMMaint,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.GetWIPMsgs(uOMMaint, (UOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      UOMMaint uOMMaint,
      UOMMaint_Parameters parameters,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) uOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUOMMaintService) this._Channel).Load(this._UserProfile, uOMMaint, parameters, request, out result) : this.AddMethod((Method) new UOMMaintMethod(uOMMaint, UOMMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) uOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((UOMMaint) null, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus Load(UOMMaint uOMMaint)
    {
      return this.Load(uOMMaint, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus Load(
      UOMMaint uOMMaint,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.Load(uOMMaint, (UOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      UOMMaint uOMMaint,
      UOMMaint_LoadESigDetails_Parameters parameters,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) uOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUOMMaintService) this._Channel).LoadESigDetails(this._UserProfile, uOMMaint, parameters, request, out result) : this.AddMethod((Method) new UOMMaintMethod(uOMMaint, UOMMaintMethods.LoadESigDetails, (UOMMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) uOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((UOMMaint) null, (UOMMaint_LoadESigDetails_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus LoadESigDetails(UOMMaint uOMMaint)
    {
      return this.LoadESigDetails(uOMMaint, (UOMMaint_LoadESigDetails_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      UOMMaint uOMMaint,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.LoadESigDetails(uOMMaint, (UOMMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      UOMMaint uOMMaint,
      UOMMaint_Parameters parameters,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) uOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUOMMaintService) this._Channel).New(this._UserProfile, uOMMaint, parameters, request, out result) : this.AddMethod((Method) new UOMMaintMethod(uOMMaint, UOMMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) uOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((UOMMaint) null, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus New(UOMMaint uOMMaint)
    {
      return this.New(uOMMaint, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus New(
      UOMMaint uOMMaint,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.New(uOMMaint, (UOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      UOMMaint uOMMaint,
      UOMMaint_Parameters parameters,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) uOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUOMMaintService) this._Channel).NewCopy(this._UserProfile, uOMMaint, parameters, request, out result) : this.AddMethod((Method) new UOMMaintMethod(uOMMaint, UOMMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) uOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((UOMMaint) null, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus NewCopy(UOMMaint uOMMaint)
    {
      return this.NewCopy(uOMMaint, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus NewCopy(
      UOMMaint uOMMaint,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.NewCopy(uOMMaint, (UOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      UOMMaint uOMMaint,
      UOMMaint_Parameters parameters,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) uOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUOMMaintService) this._Channel).SaveAs(this._UserProfile, uOMMaint, parameters, request, out result) : this.AddMethod((Method) new UOMMaintMethod(uOMMaint, UOMMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) uOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((UOMMaint) null, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus SaveAs(UOMMaint uOMMaint)
    {
      return this.SaveAs(uOMMaint, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus SaveAs(
      UOMMaint uOMMaint,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.SaveAs(uOMMaint, (UOMMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      UOMMaint uOMMaint,
      UOMMaint_Parameters parameters,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) uOMMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUOMMaintService) this._Channel).UnFreeze(this._UserProfile, uOMMaint, parameters, request, out result) : this.AddMethod((Method) new UOMMaintMethod(uOMMaint, UOMMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) uOMMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((UOMMaint) null, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus UnFreeze(UOMMaint uOMMaint)
    {
      return this.UnFreeze(uOMMaint, (UOMMaint_Parameters) null, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus UnFreeze(
      UOMMaint uOMMaint,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.UnFreeze(uOMMaint, (UOMMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject uOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UOMMaint_Result result1;
        ResultStatus resultStatus = this.Delete((UOMMaint) uOMMaint, (UOMMaint_Parameters) parameters, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject uOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UOMMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((UOMMaint) uOMMaint, (UOMMaint_Parameters) parameters, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject uOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UOMMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((UOMMaint) uOMMaint, (UOMMaint_LoadESigDetails_Parameters) parameters, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject uOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UOMMaint_Result result1;
        ResultStatus resultStatus = this.New((UOMMaint) uOMMaint, (UOMMaint_Parameters) parameters, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject uOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UOMMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((UOMMaint) uOMMaint, (UOMMaint_Parameters) parameters, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject uOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UOMMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((UOMMaint) uOMMaint, (UOMMaint_Parameters) parameters, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject uOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UOMMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((UOMMaint) uOMMaint, (UOMMaint_Parameters) parameters, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject uOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UOMMaint_Result result1;
        ResultStatus resultStatus = this.Load((UOMMaint) uOMMaint, (UOMMaint_Parameters) parameters, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject uOMMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        UOMMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((UOMMaint) uOMMaint, (UOMMaint_Parameters) parameters, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      try
      {
        UOMMaintMethod[] methods = new UOMMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IUOMMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        UOMMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UOMMaint cdo,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      try
      {
        return ((IUOMMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        UOMMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((UOMMaint) cdo, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.GetEnvironment((UOMMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      UOMMaint cdo,
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      result = (UOMMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IUOMMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new UOMMaintMethod(cdo, UOMMaintMethods.ExecuteTransaction, (UOMMaint_Parameters) null));
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
        UOMMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((UOMMaint) cdo, (UOMMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(UOMMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (UOMMaint_Request) null, out UOMMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      UOMMaint_Request request,
      out UOMMaint_Result result)
    {
      return this.ExecuteTransaction((UOMMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(UOMMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new UOMMaintMethod(cdo, UOMMaintMethods.AddDataTransaction, (UOMMaint_Parameters) null));
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
        return this.AddDataTransaction((UOMMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
