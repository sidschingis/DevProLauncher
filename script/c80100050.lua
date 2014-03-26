--竜姫神サフィラ
function c80100050.initial_effect(c)
        --xyz summon
        c:EnableReviveLimit()
        --draw
		local e1=Effect.CreateEffect(c)
		e1:SetDescription(aux.Stringid(80100050,0))
		e1:SetCategory(CATEGORY_DRAW+CATEGORY_HANDES)
		e1:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_TRIGGER_O)
		e1:SetRange(LOCATION_MZONE)
		e1:SetCode(EVENT_PHASE+PHASE_END)
		e1:SetCost(c80100050.cost)
		e1:SetCondition(c80100050.con)
		e1:SetTarget(c80100050.tg)
		e1:SetOperation(c80100050.op)
		c:RegisterEffect(e1)
		--discard
		local e2=e1:Clone()
		e2:SetDescription(aux.Stringid(80100050,1))
		e2:SetCategory(CATEGORY_HANDES)
		e2:SetTarget(c80100050.tg1)
		e2:SetOperation(c80100050.op1)
		c:RegisterEffect(e2)
		--discard
		local e3=e1:Clone()
		e3:SetDescription(aux.Stringid(80100050,2))
		e3:SetCategory(CATEGORY_TOHAND)
		e3:SetTarget(c80100050.tg2)
		e3:SetOperation(c80100050.op2)
		c:RegisterEffect(e3)
		--Register
		local e4=Effect.CreateEffect(c)
		e4:SetType(EFFECT_TYPE_SINGLE+EFFECT_TYPE_CONTINUOUS)
		e4:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
		e4:SetCode(EVENT_SPSUMMON_SUCCESS)
		e4:SetCondition(c80100050.regcon)
		e4:SetOperation(c80100050.regop)
		c:RegisterEffect(e4)
		local e5=Effect.CreateEffect(c)
		e5:SetType(EFFECT_TYPE_FIELD+EFFECT_TYPE_CONTINUOUS)
		e5:SetProperty(EFFECT_FLAG_CANNOT_DISABLE)
		e5:SetRange(LOCATION_MZONE)
		e5:SetCode(EVENT_TO_GRAVE)
		e5:SetCondition(c80100050.regcon1)
		e5:SetOperation(c80100050.regop)
		c:RegisterEffect(e5)
end
function c80100050.con(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetFlagEffect(80100050)>0
end
function c80100050.cost(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetFlagEffect(tp,80100050)==0 end
	Duel.RegisterFlagEffect(tp,80100050,RESET_PHASE+PHASE_END,0,1)
end
function c80100050.tg(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.IsPlayerCanDraw(tp,2)end
	Duel.Hint(HINT_OPSELECTED,1-tp,e:GetDescription())
	Duel.SetTargetPlayer(tp)
	Duel.SetTargetParam(2)
	Duel.SetOperationInfo(0,CATEGORY_DRAW,nil,0,tp,2)
	Duel.SetOperationInfo(0,CATEGORY_HANDES,nil,0,tp,1)
	e:GetHandler():ResetNegateEffect(25789292,97268402)
end
function c80100050.op(e,tp,eg,ep,ev,re,r,rp)
	local p,d=Duel.GetChainInfo(0,CHAININFO_TARGET_PLAYER,CHAININFO_TARGET_PARAM)
	if Duel.Draw(p,d,REASON_EFFECT)==2 then
		Duel.ShuffleHand(tp)
		Duel.BreakEffect()
		Duel.DiscardHand(tp,aux.TRUE,1,1,REASON_EFFECT+REASON_DISCARD)
	end
end
function c80100050.tg1(e,tp,eg,ep,ev,re,r,rp,chk)
	if chk==0 then return Duel.GetFieldGroupCount(tp,0,LOCATION_HAND)>0 end
	Duel.Hint(HINT_OPSELECTED,1-tp,e:GetDescription())	
	Duel.SetOperationInfo(0,CATEGORY_HANDES,0,0,1-tp,1)
	e:GetHandler():ResetNegateEffect(25789292,97268402)
end
function c80100050.op1(e,tp,eg,ep,ev,re,r,rp)
	local g=Duel.GetFieldGroup(ep,0,LOCATION_HAND)
	if g:GetCount()==0 then return end
	local sg=g:RandomSelect(1-tp,1)
	Duel.SendtoGrave(sg,REASON_DISCARD+REASON_EFFECT)
end
function c80100050.filter(c)
	return c:IsAttribute(ATTRIBUTE_LIGHT) and c:IsAbleToHand()
end
function c80100050.tg2(e,tp,eg,ep,ev,re,r,rp,chk,chkc)
	if chk==0 then return Duel.IsExistingMatchingCard(c80100050.thfilter,tp,LOCATION_GRAVE,0,1,nil) end
	Duel.Hint(HINT_OPSELECTED,1-tp,e:GetDescription())	
	Duel.SetOperationInfo(0,CATEGORY_TOHAND,nil,1,tp,LOCATION_GRAVE)
	e:GetHandler():ResetNegateEffect(25789292,97268402)
end
function c80100050.op2(e,tp,eg,ep,ev,re,r,rp)
	Duel.Hint(HINT_SELECTMSG,tp,HINTMSG_ATOHAND)
	local g=Duel.SelectMatchingCard(tp,c80100050.filter,tp,LOCATION_GRAVE,0,1,1,nil)
	if g:GetCount()>0 then
		Duel.SendtoHand(g,nil,REASON_EFFECT)
		Duel.ConfirmCards(1-tp,g)
	end
end
function c80100050.regcon(e,tp,eg,ep,ev,re,r,rp)
	return e:GetHandler():GetSummonType()==SUMMON_TYPE_RITUAL
end
function c80100050.rfilter(c,tp)
	return c:IsControler(tp) and c:GetPreviousControler()==tp and 
		c:IsPreviousLocation(LOCATION_HAND+LOCATION_DECK)
		and c:IsAttribute(ATTRIBUTE_LIGHT)
end
function c80100050.regcon1(e,tp,eg,ep,ev,re,r,rp)
	return eg:IsExists(c80100050.rfilter,1,nil,tp)
end
function c80100050.regop(e,tp,eg,ep,ev,re,r,rp)
	e:GetHandler():RegisterFlagEffect(80100050,RESET_EVENT+0x1fe0000+RESET_PHASE+PHASE_END,0,1)
end