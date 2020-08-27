// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.SwitchingRuleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class SwitchingRuleMaintService : RevisionedObjectMaintBase
  {
    public SwitchingRuleMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (ISwitchingRuleMaintService), userProfile);
    }

    public ResultStatus Delete(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).Delete(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus Delete(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.Delete(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus Delete(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.Delete(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteAllRevisions(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteAllRevisions), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).DeleteAllRevisions(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.DeleteAllRevisions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteAllRevisions), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteAllRevisions()
    {
      return this.DeleteAllRevisions((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.DeleteAllRevisions(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus DeleteAllRevisions(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.DeleteAllRevisions(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).Freeze(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus Freeze(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.Freeze(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus Freeze(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.Freeze(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).GetWIPMsgs(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.GetWIPMsgs(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.GetWIPMsgs(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).Load(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus Load(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.Load(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus Load(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.Load(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_LoadESigDetails_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).LoadESigDetails(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.LoadESigDetails, (SwitchingRuleMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((SwitchingRuleMaint) null, (SwitchingRuleMaint_LoadESigDetails_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.LoadESigDetails(switchingRuleMaint, (SwitchingRuleMaint_LoadESigDetails_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.LoadESigDetails(switchingRuleMaint, (SwitchingRuleMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).New(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus New(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.New(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus New(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.New(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).NewCopy(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus NewCopy(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.NewCopy(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus NewCopy(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.NewCopy(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRev(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (NewRev), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).NewRev(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.NewRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRev), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRev()
    {
      return this.NewRev((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus NewRev(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.NewRev(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus NewRev(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.NewRev(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewRevCopy(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (NewRevCopy), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).NewRevCopy(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.NewRevCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewRevCopy), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewRevCopy()
    {
      return this.NewRevCopy((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus NewRevCopy(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.NewRevCopy(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus NewRevCopy(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.NewRevCopy(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).SaveAs(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus SaveAs(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.SaveAs(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus SaveAs(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.SaveAs(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAsRev(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAsRev), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).SaveAsRev(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.SaveAsRev, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAsRev), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAsRev()
    {
      return this.SaveAsRev((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus SaveAsRev(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.SaveAsRev(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus SaveAsRev(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.SaveAsRev(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Parameters parameters,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).UnFreeze(this._UserProfile, switchingRuleMaint, parameters, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(switchingRuleMaint, SwitchingRuleMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) switchingRuleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((SwitchingRuleMaint) null, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(SwitchingRuleMaint switchingRuleMaint)
    {
      return this.UnFreeze(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus UnFreeze(
      SwitchingRuleMaint switchingRuleMaint,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.UnFreeze(switchingRuleMaint, (SwitchingRuleMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDeleteAllRevisions(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.DeleteAllRevisions((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRev(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.NewRev((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewRevCopy(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.NewRevCopy((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAsRev(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.SaveAsRev((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnDelete(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.Delete((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_LoadESigDetails_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.New((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.Load((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject switchingRuleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        SwitchingRuleMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((SwitchingRuleMaint) switchingRuleMaint, (SwitchingRuleMaint_Parameters) parameters, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      try
      {
        SwitchingRuleMaintMethod[] methods = new SwitchingRuleMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((ISwitchingRuleMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SwitchingRuleMaint cdo,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      try
      {
        return ((ISwitchingRuleMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        SwitchingRuleMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((SwitchingRuleMaint) cdo, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.GetEnvironment((SwitchingRuleMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      SwitchingRuleMaint cdo,
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      result = (SwitchingRuleMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((ISwitchingRuleMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new SwitchingRuleMaintMethod(cdo, SwitchingRuleMaintMethods.ExecuteTransaction, (SwitchingRuleMaint_Parameters) null));
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
        SwitchingRuleMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((SwitchingRuleMaint) cdo, (SwitchingRuleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(SwitchingRuleMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (SwitchingRuleMaint_Request) null, out SwitchingRuleMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      SwitchingRuleMaint_Request request,
      out SwitchingRuleMaint_Result result)
    {
      return this.ExecuteTransaction((SwitchingRuleMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(SwitchingRuleMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new SwitchingRuleMaintMethod(cdo, SwitchingRuleMaintMethods.AddDataTransaction, (SwitchingRuleMaint_Parameters) null));
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
        return this.AddDataTransaction((SwitchingRuleMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
