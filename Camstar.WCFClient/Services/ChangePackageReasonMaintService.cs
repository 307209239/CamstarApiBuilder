// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ChangePackageReasonMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class ChangePackageReasonMaintService : UserCodeMaintBase
  {
    public ChangePackageReasonMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IChangePackageReasonMaintService), userProfile);
    }

    public ResultStatus Delete(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageReasonMaintService) this._Channel).Delete(this._UserProfile, changePackageReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackageReasonMaintMethod(changePackageReasonMaint, ChangePackageReasonMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((ChangePackageReasonMaint) null, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus Delete(ChangePackageReasonMaint changePackageReasonMaint)
    {
      return this.Delete(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus Delete(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.Delete(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageReasonMaintService) this._Channel).Freeze(this._UserProfile, changePackageReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackageReasonMaintMethod(changePackageReasonMaint, ChangePackageReasonMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((ChangePackageReasonMaint) null, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus Freeze(ChangePackageReasonMaint changePackageReasonMaint)
    {
      return this.Freeze(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus Freeze(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.Freeze(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageReasonMaintService) this._Channel).GetWIPMsgs(this._UserProfile, changePackageReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackageReasonMaintMethod(changePackageReasonMaint, ChangePackageReasonMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((ChangePackageReasonMaint) null, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(ChangePackageReasonMaint changePackageReasonMaint)
    {
      return this.GetWIPMsgs(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.GetWIPMsgs(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageReasonMaintService) this._Channel).Load(this._UserProfile, changePackageReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackageReasonMaintMethod(changePackageReasonMaint, ChangePackageReasonMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((ChangePackageReasonMaint) null, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus Load(ChangePackageReasonMaint changePackageReasonMaint)
    {
      return this.Load(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus Load(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.Load(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_LoadESigDetails_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageReasonMaintService) this._Channel).LoadESigDetails(this._UserProfile, changePackageReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackageReasonMaintMethod(changePackageReasonMaint, ChangePackageReasonMaintMethods.LoadESigDetails, (ChangePackageReasonMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((ChangePackageReasonMaint) null, (ChangePackageReasonMaint_LoadESigDetails_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangePackageReasonMaint changePackageReasonMaint)
    {
      return this.LoadESigDetails(changePackageReasonMaint, (ChangePackageReasonMaint_LoadESigDetails_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.LoadESigDetails(changePackageReasonMaint, (ChangePackageReasonMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageReasonMaintService) this._Channel).New(this._UserProfile, changePackageReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackageReasonMaintMethod(changePackageReasonMaint, ChangePackageReasonMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((ChangePackageReasonMaint) null, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus New(ChangePackageReasonMaint changePackageReasonMaint)
    {
      return this.New(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus New(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.New(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageReasonMaintService) this._Channel).NewCopy(this._UserProfile, changePackageReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackageReasonMaintMethod(changePackageReasonMaint, ChangePackageReasonMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((ChangePackageReasonMaint) null, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus NewCopy(ChangePackageReasonMaint changePackageReasonMaint)
    {
      return this.NewCopy(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus NewCopy(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.NewCopy(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageReasonMaintService) this._Channel).SaveAs(this._UserProfile, changePackageReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackageReasonMaintMethod(changePackageReasonMaint, ChangePackageReasonMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((ChangePackageReasonMaint) null, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus SaveAs(ChangePackageReasonMaint changePackageReasonMaint)
    {
      return this.SaveAs(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus SaveAs(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.SaveAs(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Parameters parameters,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageReasonMaintService) this._Channel).UnFreeze(this._UserProfile, changePackageReasonMaint, parameters, request, out result) : this.AddMethod((Method) new ChangePackageReasonMaintMethod(changePackageReasonMaint, ChangePackageReasonMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) changePackageReasonMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((ChangePackageReasonMaint) null, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(ChangePackageReasonMaint changePackageReasonMaint)
    {
      return this.UnFreeze(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus UnFreeze(
      ChangePackageReasonMaint changePackageReasonMaint,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.UnFreeze(changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject changePackageReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageReasonMaint_Result result1;
        ResultStatus resultStatus = this.Delete((ChangePackageReasonMaint) changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) parameters, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject changePackageReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageReasonMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((ChangePackageReasonMaint) changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) parameters, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject changePackageReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageReasonMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((ChangePackageReasonMaint) changePackageReasonMaint, (ChangePackageReasonMaint_LoadESigDetails_Parameters) parameters, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject changePackageReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageReasonMaint_Result result1;
        ResultStatus resultStatus = this.New((ChangePackageReasonMaint) changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) parameters, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject changePackageReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageReasonMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((ChangePackageReasonMaint) changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) parameters, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject changePackageReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageReasonMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((ChangePackageReasonMaint) changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) parameters, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject changePackageReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageReasonMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((ChangePackageReasonMaint) changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) parameters, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject changePackageReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageReasonMaint_Result result1;
        ResultStatus resultStatus = this.Load((ChangePackageReasonMaint) changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) parameters, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject changePackageReasonMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        ChangePackageReasonMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((ChangePackageReasonMaint) changePackageReasonMaint, (ChangePackageReasonMaint_Parameters) parameters, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      try
      {
        ChangePackageReasonMaintMethod[] methods = new ChangePackageReasonMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IChangePackageReasonMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        ChangePackageReasonMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangePackageReasonMaint cdo,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      try
      {
        return ((IChangePackageReasonMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        ChangePackageReasonMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((ChangePackageReasonMaint) cdo, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.GetEnvironment((ChangePackageReasonMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      ChangePackageReasonMaint cdo,
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      result = (ChangePackageReasonMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IChangePackageReasonMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new ChangePackageReasonMaintMethod(cdo, ChangePackageReasonMaintMethods.ExecuteTransaction, (ChangePackageReasonMaint_Parameters) null));
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
        ChangePackageReasonMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((ChangePackageReasonMaint) cdo, (ChangePackageReasonMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(ChangePackageReasonMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (ChangePackageReasonMaint_Request) null, out ChangePackageReasonMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      ChangePackageReasonMaint_Request request,
      out ChangePackageReasonMaint_Result result)
    {
      return this.ExecuteTransaction((ChangePackageReasonMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(ChangePackageReasonMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new ChangePackageReasonMaintMethod(cdo, ChangePackageReasonMaintMethods.AddDataTransaction, (ChangePackageReasonMaint_Parameters) null));
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
        return this.AddDataTransaction((ChangePackageReasonMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
