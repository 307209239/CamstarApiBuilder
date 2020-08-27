// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.WIPMsgMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class WIPMsgMaintService : MaintenanceBase
  {
    public WIPMsgMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IWIPMsgMaintService), userProfile);
    }

    public ResultStatus AddAllKeyDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (AddAllKeyDetail), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).AddAllKeyDetail(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.AddAllKeyDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddAllKeyDetail), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddAllKeyDetail()
    {
      return this.AddAllKeyDetail((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus AddAllKeyDetail(WIPMsgMaint wIPMsgMaint)
    {
      return this.AddAllKeyDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus AddAllKeyDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.AddAllKeyDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus AddLabelDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (AddLabelDetail), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).AddLabelDetail(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.AddLabelDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddLabelDetail), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddLabelDetail()
    {
      return this.AddLabelDetail((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus AddLabelDetail(WIPMsgMaint wIPMsgMaint)
    {
      return this.AddLabelDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus AddLabelDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.AddLabelDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus AddOperationDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (AddOperationDetail), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).AddOperationDetail(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.AddOperationDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddOperationDetail), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddOperationDetail()
    {
      return this.AddOperationDetail((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus AddOperationDetail(WIPMsgMaint wIPMsgMaint)
    {
      return this.AddOperationDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus AddOperationDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.AddOperationDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus ClearAllKey(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (ClearAllKey), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).ClearAllKey(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.ClearAllKey, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ClearAllKey), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ClearAllKey()
    {
      return this.ClearAllKey((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus ClearAllKey(WIPMsgMaint wIPMsgMaint)
    {
      return this.ClearAllKey(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus ClearAllKey(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.ClearAllKey(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).Delete(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus Delete(WIPMsgMaint wIPMsgMaint)
    {
      return this.Delete(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus Delete(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.Delete(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteDetail), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).DeleteDetail(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.DeleteDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteDetail), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteDetail()
    {
      return this.DeleteDetail((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus DeleteDetail(WIPMsgMaint wIPMsgMaint)
    {
      return this.DeleteDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus DeleteDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.DeleteDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteLabelKey(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteLabelKey), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).DeleteLabelKey(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.DeleteLabelKey, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteLabelKey), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteLabelKey()
    {
      return this.DeleteLabelKey((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus DeleteLabelKey(WIPMsgMaint wIPMsgMaint)
    {
      return this.DeleteLabelKey(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus DeleteLabelKey(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.DeleteLabelKey(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteOprKey(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteOprKey), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).DeleteOprKey(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.DeleteOprKey, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteOprKey), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteOprKey()
    {
      return this.DeleteOprKey((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus DeleteOprKey(WIPMsgMaint wIPMsgMaint)
    {
      return this.DeleteOprKey(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus DeleteOprKey(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.DeleteOprKey(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).Freeze(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus Freeze(WIPMsgMaint wIPMsgMaint)
    {
      return this.Freeze(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus Freeze(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.Freeze(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).GetWIPMsgs(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(WIPMsgMaint wIPMsgMaint)
    {
      return this.GetWIPMsgs(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.GetWIPMsgs(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).Load(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus Load(WIPMsgMaint wIPMsgMaint)
    {
      return this.Load(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus Load(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.Load(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (LoadDetail), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).LoadDetail(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.LoadDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadDetail), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadDetail()
    {
      return this.LoadDetail((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus LoadDetail(WIPMsgMaint wIPMsgMaint)
    {
      return this.LoadDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus LoadDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.LoadDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_LoadESigDetails_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).LoadESigDetails(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.LoadESigDetails, (WIPMsgMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((WIPMsgMaint) null, (WIPMsgMaint_LoadESigDetails_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus LoadESigDetails(WIPMsgMaint wIPMsgMaint)
    {
      return this.LoadESigDetails(wIPMsgMaint, (WIPMsgMaint_LoadESigDetails_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.LoadESigDetails(wIPMsgMaint, (WIPMsgMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).New(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus New(WIPMsgMaint wIPMsgMaint)
    {
      return this.New(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus New(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.New(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).NewCopy(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus NewCopy(WIPMsgMaint wIPMsgMaint)
    {
      return this.NewCopy(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus NewCopy(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.NewCopy(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).SaveAs(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SaveAs(WIPMsgMaint wIPMsgMaint)
    {
      return this.SaveAs(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SaveAs(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.SaveAs(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsAllDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsAllDetail), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).SaveAsAllDetail(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.SaveAsAllDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsAllDetail), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsAllDetail()
    {
      return this.SaveAsAllDetail((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SaveAsAllDetail(WIPMsgMaint wIPMsgMaint)
    {
      return this.SaveAsAllDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SaveAsAllDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.SaveAsAllDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsLabelDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsLabelDetail), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).SaveAsLabelDetail(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.SaveAsLabelDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsLabelDetail), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsLabelDetail()
    {
      return this.SaveAsLabelDetail((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SaveAsLabelDetail(WIPMsgMaint wIPMsgMaint)
    {
      return this.SaveAsLabelDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SaveAsLabelDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.SaveAsLabelDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsOperationDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsOperationDetail), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).SaveAsOperationDetail(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.SaveAsOperationDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsOperationDetail), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsOperationDetail()
    {
      return this.SaveAsOperationDetail((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SaveAsOperationDetail(WIPMsgMaint wIPMsgMaint)
    {
      return this.SaveAsOperationDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SaveAsOperationDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.SaveAsOperationDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (SaveDetail), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).SaveDetail(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.SaveDetail, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveDetail), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveDetail()
    {
      return this.SaveDetail((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SaveDetail(WIPMsgMaint wIPMsgMaint)
    {
      return this.SaveDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SaveDetail(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.SaveDetail(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus SetCompletionMessageAdd(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (SetCompletionMessageAdd), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).SetCompletionMessageAdd(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.SetCompletionMessageAdd, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetCompletionMessageAdd), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetCompletionMessageAdd()
    {
      return this.SetCompletionMessageAdd((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SetCompletionMessageAdd(WIPMsgMaint wIPMsgMaint)
    {
      return this.SetCompletionMessageAdd(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SetCompletionMessageAdd(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.SetCompletionMessageAdd(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus SetCompletionMessageChange(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (SetCompletionMessageChange), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).SetCompletionMessageChange(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.SetCompletionMessageChange, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetCompletionMessageChange), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetCompletionMessageChange()
    {
      return this.SetCompletionMessageChange((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SetCompletionMessageChange(WIPMsgMaint wIPMsgMaint)
    {
      return this.SetCompletionMessageChange(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SetCompletionMessageChange(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.SetCompletionMessageChange(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus SetCompletionMessageDelete(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (SetCompletionMessageDelete), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).SetCompletionMessageDelete(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.SetCompletionMessageDelete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetCompletionMessageDelete), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetCompletionMessageDelete()
    {
      return this.SetCompletionMessageDelete((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SetCompletionMessageDelete(WIPMsgMaint wIPMsgMaint)
    {
      return this.SetCompletionMessageDelete(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SetCompletionMessageDelete(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.SetCompletionMessageDelete(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus SetCompletionMessageLoad(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (SetCompletionMessageLoad), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).SetCompletionMessageLoad(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.SetCompletionMessageLoad, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SetCompletionMessageLoad), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SetCompletionMessageLoad()
    {
      return this.SetCompletionMessageLoad((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SetCompletionMessageLoad(WIPMsgMaint wIPMsgMaint)
    {
      return this.SetCompletionMessageLoad(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus SetCompletionMessageLoad(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.SetCompletionMessageLoad(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Parameters parameters,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).UnFreeze(this._UserProfile, wIPMsgMaint, parameters, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(wIPMsgMaint, WIPMsgMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) wIPMsgMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((WIPMsgMaint) null, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus UnFreeze(WIPMsgMaint wIPMsgMaint)
    {
      return this.UnFreeze(wIPMsgMaint, (WIPMsgMaint_Parameters) null, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus UnFreeze(
      WIPMsgMaint wIPMsgMaint,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.UnFreeze(wIPMsgMaint, (WIPMsgMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject wIPMsgMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WIPMsgMaint_Result result1;
        ResultStatus resultStatus = this.Delete((WIPMsgMaint) wIPMsgMaint, (WIPMsgMaint_Parameters) parameters, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject wIPMsgMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WIPMsgMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((WIPMsgMaint) wIPMsgMaint, (WIPMsgMaint_Parameters) parameters, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject wIPMsgMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WIPMsgMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((WIPMsgMaint) wIPMsgMaint, (WIPMsgMaint_LoadESigDetails_Parameters) parameters, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject wIPMsgMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WIPMsgMaint_Result result1;
        ResultStatus resultStatus = this.New((WIPMsgMaint) wIPMsgMaint, (WIPMsgMaint_Parameters) parameters, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject wIPMsgMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WIPMsgMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((WIPMsgMaint) wIPMsgMaint, (WIPMsgMaint_Parameters) parameters, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject wIPMsgMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WIPMsgMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((WIPMsgMaint) wIPMsgMaint, (WIPMsgMaint_Parameters) parameters, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject wIPMsgMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WIPMsgMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((WIPMsgMaint) wIPMsgMaint, (WIPMsgMaint_Parameters) parameters, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject wIPMsgMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WIPMsgMaint_Result result1;
        ResultStatus resultStatus = this.Load((WIPMsgMaint) wIPMsgMaint, (WIPMsgMaint_Parameters) parameters, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject wIPMsgMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        WIPMsgMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((WIPMsgMaint) wIPMsgMaint, (WIPMsgMaint_Parameters) parameters, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      try
      {
        WIPMsgMaintMethod[] methods = new WIPMsgMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IWIPMsgMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        WIPMsgMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WIPMsgMaint cdo,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      try
      {
        return ((IWIPMsgMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        WIPMsgMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((WIPMsgMaint) cdo, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.GetEnvironment((WIPMsgMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      WIPMsgMaint cdo,
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      result = (WIPMsgMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IWIPMsgMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new WIPMsgMaintMethod(cdo, WIPMsgMaintMethods.ExecuteTransaction, (WIPMsgMaint_Parameters) null));
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
        WIPMsgMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((WIPMsgMaint) cdo, (WIPMsgMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(WIPMsgMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (WIPMsgMaint_Request) null, out WIPMsgMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      WIPMsgMaint_Request request,
      out WIPMsgMaint_Result result)
    {
      return this.ExecuteTransaction((WIPMsgMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(WIPMsgMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new WIPMsgMaintMethod(cdo, WIPMsgMaintMethods.AddDataTransaction, (WIPMsgMaint_Parameters) null));
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
        return this.AddDataTransaction((WIPMsgMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
