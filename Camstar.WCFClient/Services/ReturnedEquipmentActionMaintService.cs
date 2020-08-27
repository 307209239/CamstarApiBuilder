// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ReturnedEquipmentActionMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ReturnedEquipmentActionMaintService : UserCodeMaintBase
  {
    public ReturnedEquipmentActionMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IReturnedEquipmentActionMaintService), userProfile);
    }

    public ResultStatus Delete(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReturnedEquipmentActionMaintService) this._Channel).Delete(this._UserProfile, returnedEquipmentActionMaint, parameters, request, out result) : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(returnedEquipmentActionMaint, ReturnedEquipmentActionMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ReturnedEquipmentActionMaint) null, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus Delete(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint)
    {
      return this.Delete(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus Delete(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.Delete(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReturnedEquipmentActionMaintService) this._Channel).Freeze(this._UserProfile, returnedEquipmentActionMaint, parameters, request, out result) : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(returnedEquipmentActionMaint, ReturnedEquipmentActionMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ReturnedEquipmentActionMaint) null, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus Freeze(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint)
    {
      return this.Freeze(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus Freeze(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.Freeze(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReturnedEquipmentActionMaintService) this._Channel).GetWIPMsgs(this._UserProfile, returnedEquipmentActionMaint, parameters, request, out result) : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(returnedEquipmentActionMaint, ReturnedEquipmentActionMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ReturnedEquipmentActionMaint) null, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint)
    {
      return this.GetWIPMsgs(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.GetWIPMsgs(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReturnedEquipmentActionMaintService) this._Channel).Load(this._UserProfile, returnedEquipmentActionMaint, parameters, request, out result) : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(returnedEquipmentActionMaint, ReturnedEquipmentActionMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ReturnedEquipmentActionMaint) null, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus Load(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint)
    {
      return this.Load(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus Load(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.Load(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_LoadESigDetails_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReturnedEquipmentActionMaintService) this._Channel).LoadESigDetails(this._UserProfile, returnedEquipmentActionMaint, parameters, request, out result) : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(returnedEquipmentActionMaint, ReturnedEquipmentActionMaintMethods.LoadESigDetails, (ReturnedEquipmentActionMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ReturnedEquipmentActionMaint) null, (ReturnedEquipmentActionMaint_LoadESigDetails_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint)
    {
      return this.LoadESigDetails(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_LoadESigDetails_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.LoadESigDetails(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReturnedEquipmentActionMaintService) this._Channel).New(this._UserProfile, returnedEquipmentActionMaint, parameters, request, out result) : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(returnedEquipmentActionMaint, ReturnedEquipmentActionMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ReturnedEquipmentActionMaint) null, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus New(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint)
    {
      return this.New(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus New(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.New(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReturnedEquipmentActionMaintService) this._Channel).NewCopy(this._UserProfile, returnedEquipmentActionMaint, parameters, request, out result) : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(returnedEquipmentActionMaint, ReturnedEquipmentActionMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ReturnedEquipmentActionMaint) null, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus NewCopy(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint)
    {
      return this.NewCopy(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus NewCopy(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.NewCopy(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReturnedEquipmentActionMaintService) this._Channel).SaveAs(this._UserProfile, returnedEquipmentActionMaint, parameters, request, out result) : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(returnedEquipmentActionMaint, ReturnedEquipmentActionMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ReturnedEquipmentActionMaint) null, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus SaveAs(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint)
    {
      return this.SaveAs(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus SaveAs(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.SaveAs(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Parameters parameters,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReturnedEquipmentActionMaintService) this._Channel).UnFreeze(this._UserProfile, returnedEquipmentActionMaint, parameters, request, out result) : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(returnedEquipmentActionMaint, ReturnedEquipmentActionMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) returnedEquipmentActionMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ReturnedEquipmentActionMaint) null, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint)
    {
      return this.UnFreeze(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ReturnedEquipmentActionMaint returnedEquipmentActionMaint,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.UnFreeze(returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject returnedEquipmentActionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ReturnedEquipmentActionMaint) returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) parameters, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject returnedEquipmentActionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ReturnedEquipmentActionMaint) returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) parameters, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject returnedEquipmentActionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ReturnedEquipmentActionMaint) returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_LoadESigDetails_Parameters) parameters, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject returnedEquipmentActionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus resultStatus = this.New((ReturnedEquipmentActionMaint) returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) parameters, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject returnedEquipmentActionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ReturnedEquipmentActionMaint) returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) parameters, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject returnedEquipmentActionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ReturnedEquipmentActionMaint) returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) parameters, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject returnedEquipmentActionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ReturnedEquipmentActionMaint) returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) parameters, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject returnedEquipmentActionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus resultStatus = this.Load((ReturnedEquipmentActionMaint) returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) parameters, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject returnedEquipmentActionMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ReturnedEquipmentActionMaint) returnedEquipmentActionMaint, (ReturnedEquipmentActionMaint_Parameters) parameters, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      try
      {
        ReturnedEquipmentActionMaintMethod[] methods = new ReturnedEquipmentActionMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IReturnedEquipmentActionMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReturnedEquipmentActionMaint cdo,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      try
      {
        return ((IReturnedEquipmentActionMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ReturnedEquipmentActionMaint) cdo, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.GetEnvironment((ReturnedEquipmentActionMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ReturnedEquipmentActionMaint cdo,
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      result = (ReturnedEquipmentActionMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IReturnedEquipmentActionMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(cdo, ReturnedEquipmentActionMaintMethods.ExecuteTransaction, (ReturnedEquipmentActionMaint_Parameters) null));
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
        ReturnedEquipmentActionMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ReturnedEquipmentActionMaint) cdo, (ReturnedEquipmentActionMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ReturnedEquipmentActionMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ReturnedEquipmentActionMaint_Request) null, out ReturnedEquipmentActionMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ReturnedEquipmentActionMaint_Request request,
      out ReturnedEquipmentActionMaint_Result result)
    {
      return this.ExecuteTransaction((ReturnedEquipmentActionMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ReturnedEquipmentActionMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ReturnedEquipmentActionMaintMethod(cdo, ReturnedEquipmentActionMaintMethods.AddDataTransaction, (ReturnedEquipmentActionMaint_Parameters) null));
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
        return this.AddDataTransaction((ReturnedEquipmentActionMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
