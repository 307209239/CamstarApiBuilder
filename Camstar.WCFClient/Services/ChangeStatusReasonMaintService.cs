// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangeStatusReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangeStatusReasonMaintService : UserCodeMaintBase
  {
    public ChangeStatusReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangeStatusReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusReasonMaintService) this._Channel).Delete(this._UserProfile, changeStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(changeStatusReasonMaint, ChangeStatusReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ChangeStatusReasonMaint) null, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus Delete(ChangeStatusReasonMaint changeStatusReasonMaint)
    {
      return this.Delete(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.Delete(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusReasonMaintService) this._Channel).Freeze(this._UserProfile, changeStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(changeStatusReasonMaint, ChangeStatusReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ChangeStatusReasonMaint) null, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus Freeze(ChangeStatusReasonMaint changeStatusReasonMaint)
    {
      return this.Freeze(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.Freeze(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, changeStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(changeStatusReasonMaint, ChangeStatusReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangeStatusReasonMaint) null, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangeStatusReasonMaint changeStatusReasonMaint)
    {
      return this.GetWIPMsgs(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.GetWIPMsgs(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusReasonMaintService) this._Channel).Load(this._UserProfile, changeStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(changeStatusReasonMaint, ChangeStatusReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangeStatusReasonMaint) null, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus Load(ChangeStatusReasonMaint changeStatusReasonMaint)
    {
      return this.Load(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus Load(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.Load(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_LoadESigDetails_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, changeStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(changeStatusReasonMaint, ChangeStatusReasonMaintMethods.LoadESigDetails, (ChangeStatusReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangeStatusReasonMaint) null, (ChangeStatusReasonMaint_LoadESigDetails_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(ChangeStatusReasonMaint changeStatusReasonMaint)
    {
      return this.LoadESigDetails(changeStatusReasonMaint, (ChangeStatusReasonMaint_LoadESigDetails_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.LoadESigDetails(changeStatusReasonMaint, (ChangeStatusReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusReasonMaintService) this._Channel).New(this._UserProfile, changeStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(changeStatusReasonMaint, ChangeStatusReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ChangeStatusReasonMaint) null, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus New(ChangeStatusReasonMaint changeStatusReasonMaint)
    {
      return this.New(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus New(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.New(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusReasonMaintService) this._Channel).NewCopy(this._UserProfile, changeStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(changeStatusReasonMaint, ChangeStatusReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ChangeStatusReasonMaint) null, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus NewCopy(ChangeStatusReasonMaint changeStatusReasonMaint)
    {
      return this.NewCopy(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.NewCopy(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusReasonMaintService) this._Channel).SaveAs(this._UserProfile, changeStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(changeStatusReasonMaint, ChangeStatusReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ChangeStatusReasonMaint) null, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus SaveAs(ChangeStatusReasonMaint changeStatusReasonMaint)
    {
      return this.SaveAs(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.SaveAs(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Parameters parameters,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusReasonMaintService) this._Channel).UnFreeze(this._UserProfile, changeStatusReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(changeStatusReasonMaint, ChangeStatusReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) changeStatusReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ChangeStatusReasonMaint) null, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(ChangeStatusReasonMaint changeStatusReasonMaint)
    {
      return this.UnFreeze(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ChangeStatusReasonMaint changeStatusReasonMaint,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.UnFreeze(changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject changeStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ChangeStatusReasonMaint) changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) parameters, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject changeStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ChangeStatusReasonMaint) changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) parameters, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changeStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangeStatusReasonMaint) changeStatusReasonMaint, (ChangeStatusReasonMaint_LoadESigDetails_Parameters) parameters, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject changeStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ChangeStatusReasonMaint) changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) parameters, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject changeStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ChangeStatusReasonMaint) changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) parameters, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject changeStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ChangeStatusReasonMaint) changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) parameters, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject changeStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ChangeStatusReasonMaint) changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) parameters, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changeStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ChangeStatusReasonMaint) changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) parameters, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changeStatusReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangeStatusReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangeStatusReasonMaint) changeStatusReasonMaint, (ChangeStatusReasonMaint_Parameters) parameters, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      try
      {
        ChangeStatusReasonMaintMethod[] methods = new ChangeStatusReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangeStatusReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangeStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeStatusReasonMaint cdo,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      try
      {
        return ((IChangeStatusReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangeStatusReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangeStatusReasonMaint) cdo, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.GetEnvironment((ChangeStatusReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangeStatusReasonMaint cdo,
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      result = (ChangeStatusReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangeStatusReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(cdo, ChangeStatusReasonMaintMethods.ExecuteTransaction, (ChangeStatusReasonMaint_Parameters) null));
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
        ChangeStatusReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangeStatusReasonMaint) cdo, (ChangeStatusReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangeStatusReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangeStatusReasonMaint_Request) null, out ChangeStatusReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangeStatusReasonMaint_Request request,
      out ChangeStatusReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ChangeStatusReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangeStatusReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangeStatusReasonMaintMethod(cdo, ChangeStatusReasonMaintMethods.AddDataTransaction, (ChangeStatusReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ChangeStatusReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
