// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.PortalMessageCategoryMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class PortalMessageCategoryMaintService : NamedDataObjectMaintBase
  {
    public PortalMessageCategoryMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IPortalMessageCategoryMaintService), userProfile);
    }

    public ResultStatus Delete(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMessageCategoryMaintService) this._Channel).Delete(this._UserProfile, portalMessageCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(portalMessageCategoryMaint, PortalMessageCategoryMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((PortalMessageCategoryMaint) null, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus Delete(
      PortalMessageCategoryMaint portalMessageCategoryMaint)
    {
      return this.Delete(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus Delete(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.Delete(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMessageCategoryMaintService) this._Channel).Freeze(this._UserProfile, portalMessageCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(portalMessageCategoryMaint, PortalMessageCategoryMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((PortalMessageCategoryMaint) null, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus Freeze(
      PortalMessageCategoryMaint portalMessageCategoryMaint)
    {
      return this.Freeze(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus Freeze(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.Freeze(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMessageCategoryMaintService) this._Channel).GetWIPMsgs(this._UserProfile, portalMessageCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(portalMessageCategoryMaint, PortalMessageCategoryMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((PortalMessageCategoryMaint) null, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PortalMessageCategoryMaint portalMessageCategoryMaint)
    {
      return this.GetWIPMsgs(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.GetWIPMsgs(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMessageCategoryMaintService) this._Channel).Load(this._UserProfile, portalMessageCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(portalMessageCategoryMaint, PortalMessageCategoryMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((PortalMessageCategoryMaint) null, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus Load(
      PortalMessageCategoryMaint portalMessageCategoryMaint)
    {
      return this.Load(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus Load(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.Load(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_LoadESigDetails_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMessageCategoryMaintService) this._Channel).LoadESigDetails(this._UserProfile, portalMessageCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(portalMessageCategoryMaint, PortalMessageCategoryMaintMethods.LoadESigDetails, (PortalMessageCategoryMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((PortalMessageCategoryMaint) null, (PortalMessageCategoryMaint_LoadESigDetails_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PortalMessageCategoryMaint portalMessageCategoryMaint)
    {
      return this.LoadESigDetails(portalMessageCategoryMaint, (PortalMessageCategoryMaint_LoadESigDetails_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.LoadESigDetails(portalMessageCategoryMaint, (PortalMessageCategoryMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMessageCategoryMaintService) this._Channel).New(this._UserProfile, portalMessageCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(portalMessageCategoryMaint, PortalMessageCategoryMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((PortalMessageCategoryMaint) null, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus New(
      PortalMessageCategoryMaint portalMessageCategoryMaint)
    {
      return this.New(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus New(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.New(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMessageCategoryMaintService) this._Channel).NewCopy(this._UserProfile, portalMessageCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(portalMessageCategoryMaint, PortalMessageCategoryMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((PortalMessageCategoryMaint) null, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus NewCopy(
      PortalMessageCategoryMaint portalMessageCategoryMaint)
    {
      return this.NewCopy(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus NewCopy(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.NewCopy(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMessageCategoryMaintService) this._Channel).SaveAs(this._UserProfile, portalMessageCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(portalMessageCategoryMaint, PortalMessageCategoryMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((PortalMessageCategoryMaint) null, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus SaveAs(
      PortalMessageCategoryMaint portalMessageCategoryMaint)
    {
      return this.SaveAs(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus SaveAs(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.SaveAs(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Parameters parameters,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMessageCategoryMaintService) this._Channel).UnFreeze(this._UserProfile, portalMessageCategoryMaint, parameters, request, out result) : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(portalMessageCategoryMaint, PortalMessageCategoryMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) portalMessageCategoryMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((PortalMessageCategoryMaint) null, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PortalMessageCategoryMaint portalMessageCategoryMaint)
    {
      return this.UnFreeze(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus UnFreeze(
      PortalMessageCategoryMaint portalMessageCategoryMaint,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.UnFreeze(portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject portalMessageCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMessageCategoryMaint_Result result1;
        ResultStatus resultStatus = this.Delete((PortalMessageCategoryMaint) portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) parameters, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject portalMessageCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMessageCategoryMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((PortalMessageCategoryMaint) portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) parameters, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject portalMessageCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMessageCategoryMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((PortalMessageCategoryMaint) portalMessageCategoryMaint, (PortalMessageCategoryMaint_LoadESigDetails_Parameters) parameters, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject portalMessageCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMessageCategoryMaint_Result result1;
        ResultStatus resultStatus = this.New((PortalMessageCategoryMaint) portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) parameters, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject portalMessageCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMessageCategoryMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((PortalMessageCategoryMaint) portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) parameters, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject portalMessageCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMessageCategoryMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((PortalMessageCategoryMaint) portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) parameters, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject portalMessageCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMessageCategoryMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((PortalMessageCategoryMaint) portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) parameters, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject portalMessageCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMessageCategoryMaint_Result result1;
        ResultStatus resultStatus = this.Load((PortalMessageCategoryMaint) portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) parameters, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject portalMessageCategoryMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        PortalMessageCategoryMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((PortalMessageCategoryMaint) portalMessageCategoryMaint, (PortalMessageCategoryMaint_Parameters) parameters, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      try
      {
        PortalMessageCategoryMaintMethod[] methods = new PortalMessageCategoryMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IPortalMessageCategoryMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        PortalMessageCategoryMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PortalMessageCategoryMaint cdo,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      try
      {
        return ((IPortalMessageCategoryMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        PortalMessageCategoryMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((PortalMessageCategoryMaint) cdo, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.GetEnvironment((PortalMessageCategoryMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      PortalMessageCategoryMaint cdo,
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      result = (PortalMessageCategoryMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IPortalMessageCategoryMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(cdo, PortalMessageCategoryMaintMethods.ExecuteTransaction, (PortalMessageCategoryMaint_Parameters) null));
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
        PortalMessageCategoryMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((PortalMessageCategoryMaint) cdo, (PortalMessageCategoryMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(PortalMessageCategoryMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (PortalMessageCategoryMaint_Request) null, out PortalMessageCategoryMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      PortalMessageCategoryMaint_Request request,
      out PortalMessageCategoryMaint_Result result)
    {
      return this.ExecuteTransaction((PortalMessageCategoryMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(PortalMessageCategoryMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new PortalMessageCategoryMaintMethod(cdo, PortalMessageCategoryMaintMethods.AddDataTransaction, (PortalMessageCategoryMaint_Parameters) null));
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
        return this.AddDataTransaction((PortalMessageCategoryMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
