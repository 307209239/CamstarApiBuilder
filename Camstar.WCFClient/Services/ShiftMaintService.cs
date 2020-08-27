// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ShiftMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ShiftMaintService : NamedDataObjectMaintBase
  {
    public ShiftMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IShiftMaintService), userProfile);
    }

    public ResultStatus Delete(
      ShiftMaint shiftMaint,
      ShiftMaint_Parameters parameters,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) shiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShiftMaintService) this._Channel).Delete(this._UserProfile, shiftMaint, parameters, request, out result) : this.AddMethod((Method) new ShiftMaintMethod(shiftMaint, ShiftMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) shiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ShiftMaint) null, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus Delete(ShiftMaint shiftMaint)
    {
      return this.Delete(shiftMaint, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus Delete(
      ShiftMaint shiftMaint,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.Delete(shiftMaint, (ShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ShiftMaint shiftMaint,
      ShiftMaint_Parameters parameters,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) shiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShiftMaintService) this._Channel).Freeze(this._UserProfile, shiftMaint, parameters, request, out result) : this.AddMethod((Method) new ShiftMaintMethod(shiftMaint, ShiftMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) shiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ShiftMaint) null, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus Freeze(ShiftMaint shiftMaint)
    {
      return this.Freeze(shiftMaint, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus Freeze(
      ShiftMaint shiftMaint,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.Freeze(shiftMaint, (ShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ShiftMaint shiftMaint,
      ShiftMaint_Parameters parameters,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) shiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShiftMaintService) this._Channel).GetWIPMsgs(this._UserProfile, shiftMaint, parameters, request, out result) : this.AddMethod((Method) new ShiftMaintMethod(shiftMaint, ShiftMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) shiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ShiftMaint) null, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ShiftMaint shiftMaint)
    {
      return this.GetWIPMsgs(shiftMaint, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ShiftMaint shiftMaint,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.GetWIPMsgs(shiftMaint, (ShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ShiftMaint shiftMaint,
      ShiftMaint_Parameters parameters,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) shiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShiftMaintService) this._Channel).Load(this._UserProfile, shiftMaint, parameters, request, out result) : this.AddMethod((Method) new ShiftMaintMethod(shiftMaint, ShiftMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) shiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ShiftMaint) null, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus Load(ShiftMaint shiftMaint)
    {
      return this.Load(shiftMaint, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus Load(
      ShiftMaint shiftMaint,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.Load(shiftMaint, (ShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ShiftMaint shiftMaint,
      ShiftMaint_LoadESigDetails_Parameters parameters,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) shiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShiftMaintService) this._Channel).LoadESigDetails(this._UserProfile, shiftMaint, parameters, request, out result) : this.AddMethod((Method) new ShiftMaintMethod(shiftMaint, ShiftMaintMethods.LoadESigDetails, (ShiftMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) shiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ShiftMaint) null, (ShiftMaint_LoadESigDetails_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ShiftMaint shiftMaint)
    {
      return this.LoadESigDetails(shiftMaint, (ShiftMaint_LoadESigDetails_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ShiftMaint shiftMaint,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.LoadESigDetails(shiftMaint, (ShiftMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ShiftMaint shiftMaint,
      ShiftMaint_Parameters parameters,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) shiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShiftMaintService) this._Channel).New(this._UserProfile, shiftMaint, parameters, request, out result) : this.AddMethod((Method) new ShiftMaintMethod(shiftMaint, ShiftMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) shiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ShiftMaint) null, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus New(ShiftMaint shiftMaint)
    {
      return this.New(shiftMaint, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus New(
      ShiftMaint shiftMaint,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.New(shiftMaint, (ShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ShiftMaint shiftMaint,
      ShiftMaint_Parameters parameters,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) shiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShiftMaintService) this._Channel).NewCopy(this._UserProfile, shiftMaint, parameters, request, out result) : this.AddMethod((Method) new ShiftMaintMethod(shiftMaint, ShiftMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) shiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ShiftMaint) null, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus NewCopy(ShiftMaint shiftMaint)
    {
      return this.NewCopy(shiftMaint, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus NewCopy(
      ShiftMaint shiftMaint,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.NewCopy(shiftMaint, (ShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ShiftMaint shiftMaint,
      ShiftMaint_Parameters parameters,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) shiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShiftMaintService) this._Channel).SaveAs(this._UserProfile, shiftMaint, parameters, request, out result) : this.AddMethod((Method) new ShiftMaintMethod(shiftMaint, ShiftMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) shiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ShiftMaint) null, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus SaveAs(ShiftMaint shiftMaint)
    {
      return this.SaveAs(shiftMaint, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus SaveAs(
      ShiftMaint shiftMaint,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.SaveAs(shiftMaint, (ShiftMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ShiftMaint shiftMaint,
      ShiftMaint_Parameters parameters,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) shiftMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShiftMaintService) this._Channel).UnFreeze(this._UserProfile, shiftMaint, parameters, request, out result) : this.AddMethod((Method) new ShiftMaintMethod(shiftMaint, ShiftMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) shiftMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ShiftMaint) null, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus UnFreeze(ShiftMaint shiftMaint)
    {
      return this.UnFreeze(shiftMaint, (ShiftMaint_Parameters) null, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ShiftMaint shiftMaint,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.UnFreeze(shiftMaint, (ShiftMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject shiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShiftMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ShiftMaint) shiftMaint, (ShiftMaint_Parameters) parameters, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject shiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShiftMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ShiftMaint) shiftMaint, (ShiftMaint_Parameters) parameters, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject shiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShiftMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ShiftMaint) shiftMaint, (ShiftMaint_LoadESigDetails_Parameters) parameters, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject shiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShiftMaint_Result result1;
        ResultStatus resultStatus = this.New((ShiftMaint) shiftMaint, (ShiftMaint_Parameters) parameters, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject shiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShiftMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ShiftMaint) shiftMaint, (ShiftMaint_Parameters) parameters, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject shiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShiftMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ShiftMaint) shiftMaint, (ShiftMaint_Parameters) parameters, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject shiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShiftMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ShiftMaint) shiftMaint, (ShiftMaint_Parameters) parameters, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject shiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShiftMaint_Result result1;
        ResultStatus resultStatus = this.Load((ShiftMaint) shiftMaint, (ShiftMaint_Parameters) parameters, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject shiftMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ShiftMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ShiftMaint) shiftMaint, (ShiftMaint_Parameters) parameters, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      try
      {
        ShiftMaintMethod[] methods = new ShiftMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IShiftMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ShiftMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShiftMaint cdo,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      try
      {
        return ((IShiftMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ShiftMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ShiftMaint) cdo, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.GetEnvironment((ShiftMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ShiftMaint cdo,
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      result = (ShiftMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IShiftMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ShiftMaintMethod(cdo, ShiftMaintMethods.ExecuteTransaction, (ShiftMaint_Parameters) null));
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
        ShiftMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ShiftMaint) cdo, (ShiftMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ShiftMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ShiftMaint_Request) null, out ShiftMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ShiftMaint_Request request,
      out ShiftMaint_Result result)
    {
      return this.ExecuteTransaction((ShiftMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ShiftMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ShiftMaintMethod(cdo, ShiftMaintMethods.AddDataTransaction, (ShiftMaint_Parameters) null));
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
        return this.AddDataTransaction((ShiftMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
