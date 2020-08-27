// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangePackagePriorityMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangePackagePriorityMaintService : UserCodeMaintBase
  {
    public ChangePackagePriorityMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangePackagePriorityMaintService), userProfile);
    }

    public ResultStatus Delete(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackagePriorityMaintService) this._Channel).Delete(this._UserProfile, changePackagePriorityMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(changePackagePriorityMaint, ChangePackagePriorityMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ChangePackagePriorityMaint) null, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus Delete(
      ChangePackagePriorityMaint changePackagePriorityMaint)
    {
      return this.Delete(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus Delete(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.Delete(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackagePriorityMaintService) this._Channel).Freeze(this._UserProfile, changePackagePriorityMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(changePackagePriorityMaint, ChangePackagePriorityMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ChangePackagePriorityMaint) null, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus Freeze(
      ChangePackagePriorityMaint changePackagePriorityMaint)
    {
      return this.Freeze(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus Freeze(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.Freeze(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackagePriorityMaintService) this._Channel).GetWIPMsgs(this._UserProfile, changePackagePriorityMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(changePackagePriorityMaint, ChangePackagePriorityMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangePackagePriorityMaint) null, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangePackagePriorityMaint changePackagePriorityMaint)
    {
      return this.GetWIPMsgs(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.GetWIPMsgs(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackagePriorityMaintService) this._Channel).Load(this._UserProfile, changePackagePriorityMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(changePackagePriorityMaint, ChangePackagePriorityMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangePackagePriorityMaint) null, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus Load(
      ChangePackagePriorityMaint changePackagePriorityMaint)
    {
      return this.Load(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus Load(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.Load(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_LoadESigDetails_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackagePriorityMaintService) this._Channel).LoadESigDetails(this._UserProfile, changePackagePriorityMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(changePackagePriorityMaint, ChangePackagePriorityMaintMethods.LoadESigDetails, (ChangePackagePriorityMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangePackagePriorityMaint) null, (ChangePackagePriorityMaint_LoadESigDetails_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangePackagePriorityMaint changePackagePriorityMaint)
    {
      return this.LoadESigDetails(changePackagePriorityMaint, (ChangePackagePriorityMaint_LoadESigDetails_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.LoadESigDetails(changePackagePriorityMaint, (ChangePackagePriorityMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackagePriorityMaintService) this._Channel).New(this._UserProfile, changePackagePriorityMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(changePackagePriorityMaint, ChangePackagePriorityMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ChangePackagePriorityMaint) null, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus New(
      ChangePackagePriorityMaint changePackagePriorityMaint)
    {
      return this.New(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus New(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.New(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackagePriorityMaintService) this._Channel).NewCopy(this._UserProfile, changePackagePriorityMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(changePackagePriorityMaint, ChangePackagePriorityMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ChangePackagePriorityMaint) null, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus NewCopy(
      ChangePackagePriorityMaint changePackagePriorityMaint)
    {
      return this.NewCopy(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus NewCopy(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.NewCopy(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackagePriorityMaintService) this._Channel).SaveAs(this._UserProfile, changePackagePriorityMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(changePackagePriorityMaint, ChangePackagePriorityMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ChangePackagePriorityMaint) null, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus SaveAs(
      ChangePackagePriorityMaint changePackagePriorityMaint)
    {
      return this.SaveAs(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus SaveAs(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.SaveAs(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Parameters parameters,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackagePriorityMaintService) this._Channel).UnFreeze(this._UserProfile, changePackagePriorityMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(changePackagePriorityMaint, ChangePackagePriorityMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) changePackagePriorityMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ChangePackagePriorityMaint) null, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ChangePackagePriorityMaint changePackagePriorityMaint)
    {
      return this.UnFreeze(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ChangePackagePriorityMaint changePackagePriorityMaint,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.UnFreeze(changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject changePackagePriorityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackagePriorityMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ChangePackagePriorityMaint) changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) parameters, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject changePackagePriorityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackagePriorityMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ChangePackagePriorityMaint) changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) parameters, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changePackagePriorityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackagePriorityMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangePackagePriorityMaint) changePackagePriorityMaint, (ChangePackagePriorityMaint_LoadESigDetails_Parameters) parameters, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject changePackagePriorityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackagePriorityMaint_Result result1;
        ResultStatus resultStatus = this.New((ChangePackagePriorityMaint) changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) parameters, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject changePackagePriorityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackagePriorityMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ChangePackagePriorityMaint) changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) parameters, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject changePackagePriorityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackagePriorityMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ChangePackagePriorityMaint) changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) parameters, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject changePackagePriorityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackagePriorityMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ChangePackagePriorityMaint) changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) parameters, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changePackagePriorityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackagePriorityMaint_Result result1;
        ResultStatus resultStatus = this.Load((ChangePackagePriorityMaint) changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) parameters, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changePackagePriorityMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackagePriorityMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangePackagePriorityMaint) changePackagePriorityMaint, (ChangePackagePriorityMaint_Parameters) parameters, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      try
      {
        ChangePackagePriorityMaintMethod[] methods = new ChangePackagePriorityMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangePackagePriorityMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangePackagePriorityMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangePackagePriorityMaint cdo,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      try
      {
        return ((IChangePackagePriorityMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangePackagePriorityMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangePackagePriorityMaint) cdo, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.GetEnvironment((ChangePackagePriorityMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangePackagePriorityMaint cdo,
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      result = (ChangePackagePriorityMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackagePriorityMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(cdo, ChangePackagePriorityMaintMethods.ExecuteTransaction, (ChangePackagePriorityMaint_Parameters) null));
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
        ChangePackagePriorityMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangePackagePriorityMaint) cdo, (ChangePackagePriorityMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangePackagePriorityMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangePackagePriorityMaint_Request) null, out ChangePackagePriorityMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangePackagePriorityMaint_Request request,
      out ChangePackagePriorityMaint_Result result)
    {
      return this.ExecuteTransaction((ChangePackagePriorityMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangePackagePriorityMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangePackagePriorityMaintMethod(cdo, ChangePackagePriorityMaintMethods.AddDataTransaction, (ChangePackagePriorityMaint_Parameters) null));
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
        return this.AddDataTransaction((ChangePackagePriorityMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
