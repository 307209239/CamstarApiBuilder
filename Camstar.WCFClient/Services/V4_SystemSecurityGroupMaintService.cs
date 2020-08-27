// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.V4_SystemSecurityGroupMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class V4_SystemSecurityGroupMaintService : NamedDataObjectMaintBase
  {
    public V4_SystemSecurityGroupMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IV4_SystemSecurityGroupMaintService), userProfile);
    }

    public ResultStatus Delete(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SystemSecurityGroupMaintService) this._Channel).Delete(this._UserProfile, v4_SystemSecurityGroupMaint, parameters, request, out result) : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(v4_SystemSecurityGroupMaint, V4_SystemSecurityGroupMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((V4_SystemSecurityGroupMaint) null, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus Delete(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint)
    {
      return this.Delete(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus Delete(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.Delete(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SystemSecurityGroupMaintService) this._Channel).Freeze(this._UserProfile, v4_SystemSecurityGroupMaint, parameters, request, out result) : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(v4_SystemSecurityGroupMaint, V4_SystemSecurityGroupMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((V4_SystemSecurityGroupMaint) null, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint)
    {
      return this.Freeze(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus Freeze(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.Freeze(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SystemSecurityGroupMaintService) this._Channel).GetWIPMsgs(this._UserProfile, v4_SystemSecurityGroupMaint, parameters, request, out result) : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(v4_SystemSecurityGroupMaint, V4_SystemSecurityGroupMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((V4_SystemSecurityGroupMaint) null, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint)
    {
      return this.GetWIPMsgs(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.GetWIPMsgs(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SystemSecurityGroupMaintService) this._Channel).Load(this._UserProfile, v4_SystemSecurityGroupMaint, parameters, request, out result) : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(v4_SystemSecurityGroupMaint, V4_SystemSecurityGroupMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((V4_SystemSecurityGroupMaint) null, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus Load(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint)
    {
      return this.Load(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus Load(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.Load(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_LoadESigDetails_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SystemSecurityGroupMaintService) this._Channel).LoadESigDetails(this._UserProfile, v4_SystemSecurityGroupMaint, parameters, request, out result) : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(v4_SystemSecurityGroupMaint, V4_SystemSecurityGroupMaintMethods.LoadESigDetails, (V4_SystemSecurityGroupMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((V4_SystemSecurityGroupMaint) null, (V4_SystemSecurityGroupMaint_LoadESigDetails_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint)
    {
      return this.LoadESigDetails(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_LoadESigDetails_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.LoadESigDetails(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SystemSecurityGroupMaintService) this._Channel).New(this._UserProfile, v4_SystemSecurityGroupMaint, parameters, request, out result) : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(v4_SystemSecurityGroupMaint, V4_SystemSecurityGroupMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((V4_SystemSecurityGroupMaint) null, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus New(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint)
    {
      return this.New(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus New(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.New(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SystemSecurityGroupMaintService) this._Channel).NewCopy(this._UserProfile, v4_SystemSecurityGroupMaint, parameters, request, out result) : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(v4_SystemSecurityGroupMaint, V4_SystemSecurityGroupMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((V4_SystemSecurityGroupMaint) null, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint)
    {
      return this.NewCopy(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus NewCopy(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.NewCopy(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SystemSecurityGroupMaintService) this._Channel).SaveAs(this._UserProfile, v4_SystemSecurityGroupMaint, parameters, request, out result) : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(v4_SystemSecurityGroupMaint, V4_SystemSecurityGroupMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((V4_SystemSecurityGroupMaint) null, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint)
    {
      return this.SaveAs(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus SaveAs(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.SaveAs(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Parameters parameters,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SystemSecurityGroupMaintService) this._Channel).UnFreeze(this._UserProfile, v4_SystemSecurityGroupMaint, parameters, request, out result) : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(v4_SystemSecurityGroupMaint, V4_SystemSecurityGroupMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) v4_SystemSecurityGroupMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((V4_SystemSecurityGroupMaint) null, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint)
    {
      return this.UnFreeze(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus UnFreeze(
      V4_SystemSecurityGroupMaint v4_SystemSecurityGroupMaint,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.UnFreeze(v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject v4_SystemSecurityGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus resultStatus = this.Delete((V4_SystemSecurityGroupMaint) v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) parameters, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject v4_SystemSecurityGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((V4_SystemSecurityGroupMaint) v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) parameters, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject v4_SystemSecurityGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((V4_SystemSecurityGroupMaint) v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_LoadESigDetails_Parameters) parameters, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject v4_SystemSecurityGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus resultStatus = this.New((V4_SystemSecurityGroupMaint) v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) parameters, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject v4_SystemSecurityGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((V4_SystemSecurityGroupMaint) v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) parameters, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject v4_SystemSecurityGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((V4_SystemSecurityGroupMaint) v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) parameters, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject v4_SystemSecurityGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((V4_SystemSecurityGroupMaint) v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) parameters, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject v4_SystemSecurityGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus resultStatus = this.Load((V4_SystemSecurityGroupMaint) v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) parameters, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject v4_SystemSecurityGroupMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((V4_SystemSecurityGroupMaint) v4_SystemSecurityGroupMaint, (V4_SystemSecurityGroupMaint_Parameters) parameters, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      try
      {
        V4_SystemSecurityGroupMaintMethod[] methods = new V4_SystemSecurityGroupMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IV4_SystemSecurityGroupMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_SystemSecurityGroupMaint cdo,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      try
      {
        return ((IV4_SystemSecurityGroupMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((V4_SystemSecurityGroupMaint) cdo, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.GetEnvironment((V4_SystemSecurityGroupMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      V4_SystemSecurityGroupMaint cdo,
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      result = (V4_SystemSecurityGroupMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IV4_SystemSecurityGroupMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(cdo, V4_SystemSecurityGroupMaintMethods.ExecuteTransaction, (V4_SystemSecurityGroupMaint_Parameters) null));
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
        V4_SystemSecurityGroupMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((V4_SystemSecurityGroupMaint) cdo, (V4_SystemSecurityGroupMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(V4_SystemSecurityGroupMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (V4_SystemSecurityGroupMaint_Request) null, out V4_SystemSecurityGroupMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      V4_SystemSecurityGroupMaint_Request request,
      out V4_SystemSecurityGroupMaint_Result result)
    {
      return this.ExecuteTransaction((V4_SystemSecurityGroupMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(V4_SystemSecurityGroupMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new V4_SystemSecurityGroupMaintMethod(cdo, V4_SystemSecurityGroupMaintMethods.AddDataTransaction, (V4_SystemSecurityGroupMaint_Parameters) null));
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
        return this.AddDataTransaction((V4_SystemSecurityGroupMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
