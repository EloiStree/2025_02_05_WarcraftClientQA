namespace ClientQA.Toolboxes
{
    public static class FlyCharacterToolbox
    {

        public static void JumpAndFlap3TimesWingsThenGoDown(ChampionThread champion,
            float startTimeToJump = 3,
            float timeBetweenJump = 1,
            float angleToPitchDownInSeconds = 0.4f)
        {
            champion.TapPower0();
            champion.WaitSomeSeconds(startTimeToJump);

            int compteur = 0;
            while (compteur < 3)
            {
                champion.TapJump();
                champion.WaitSomeSeconds(timeBetweenJump);
                compteur++;
            }

            champion.StartPitchDown();
            champion.WaitSomeSeconds(angleToPitchDownInSeconds);
            champion.StopPitchDown();


        }
        public static void JumpAndHover(ChampionThread champion,
            float startTimeToJump = 3,
            float timeBetweenHovering = 10,
            float angleToPitchDownInSeconds = 0.4f)
        {
            JumpAndFlap3TimesWingsThenGoDown(champion,
                startTimeToJump,
                timeBetweenHovering,
                angleToPitchDownInSeconds);

        }

    }
}
